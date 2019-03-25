package com.example.drawer;

import android.Manifest;
import android.content.Context;
import android.content.DialogInterface;
import android.content.pm.PackageManager;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.os.Bundle;
import android.support.v4.app.Fragment;
import android.support.v7.app.AlertDialog;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.MenuInflater;
import android.view.MenuItem;
import android.view.View;
import android.view.ViewGroup;

public class MainActivityFragment extends Fragment {
    private DoodleView doodleView;
    private float acceleration;
    private float currentAcceleration;
    private float lastAcceleration;

    private boolean dialogOnScreen = false;

    private static final int ACCELERATION_THRESHOLD = 100000;

    private static final int SAVE_IMAGE_PERMISSION_REQUEST_CODE = 1;

    public MainActivityFragment() {
    }

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup containet, Bundle savedInstanceState)
    {   super.onCreateView(inflater, containet, savedInstanceState);
        View view = inflater.inflate(R.layout.fragment_main, containet, false);
        setHasOptionsMenu(true);

        doodleView = (DoodleView) view.findViewById(R.id.doodleView);

        acceleration = 0.00f;
        currentAcceleration = SensorManager.GRAVITY_EARTH;
        lastAcceleration = SensorManager.GRAVITY_EARTH;
        return view;
    }
    @Override
    public void onResume() {
        super.onResume();
        enableAccelerometerListening();
    }

    private void enableAccelerometerListening() {
        SensorManager sensorManager = (SensorManager) getActivity().getSystemService(Context.SENSOR_SERVICE);

        sensorManager.registerListener(sensorEventListener,
                sensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER), SensorManager.SENSOR_DELAY_NORMAL);
    }
    @Override public void  onPause() {
        super.onPause();
        disableAccelerometerListening();
    }

    private void disableAccelerometerListening() {
        SensorManager sensorManager = (SensorManager) getActivity().getSystemService(Context.SENSOR_SERVICE);
        sensorManager.unregisterListener(sensorEventListener, sensorManager.getDefaultSensor(Sensor.TYPE_ACCELEROMETER));
    }
    private final SensorEventListener sensorEventListener = new SensorEventListener() {
        @Override
        public void onSensorChanged(SensorEvent event) {
            if (!dialogOnScreen) {
                float x = event.values[0];
                float y = event.values[1];
                float z = event.values[2];
                lastAcceleration = currentAcceleration;
                currentAcceleration = x * x + y * y + z * z;
                acceleration = currentAcceleration * (currentAcceleration - lastAcceleration);
                if (acceleration > ACCELERATION_THRESHOLD) confirmErase();
            }
        }
        @Override
        public void onAccuracyChanged(Sensor sensor, int accuracy) {
        }
    };

    private void confirmErase() {
        EraseImageDialogFragment fragment = new EraseImageDialogFragment();
        fragment.show(getFragmentManager(), "erase dialog");
    }

    @Override
    public void onCreateOptionsMenu(Menu menu, MenuInflater inflater) {
        super.onCreateOptionsMenu(menu, inflater);
        inflater.inflate(R.menu.doodle_fragment_menu, menu);
    }
     
    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Выбор в зависимости от идентификатора MenuItem
        switch (item.getItemId()) {
            case R.id.color:
                ColorDialogFragment colorDialog = new ColorDialogFragment();
                colorDialog.show(getFragmentManager(), "color dialog");
                return true; // Событие меню обработано
            case R.id.line_width:
                LineWidthDialogFragment widthDialog =
                        new LineWidthDialogFragment();
                widthDialog.show(getFragmentManager(), "line width dialog");
                return true; // Событие меню обработано
            case R.id.circle:
                DrawCircleFragment drawCircleDialog = new DrawCircleFragment();
                drawCircleDialog.show(getFragmentManager(), "Draw circle dialog");
                return true;
            case R.id.rectangle:
                DrawRectFragment drawRectDialog = new DrawRectFragment();
                drawRectDialog.show(getFragmentManager(), "Draw circle dialog");
                return true;
            case R.id.delete_drawing:
                confirmErase(); // Получить подтверждение перед стиранием
                return true; // Событие меню обработано
            case R.id.save:
                saveImage(); // Проверить разрешение и сохранить рисунок
                return true; // Событие меню обработано
            case R.id.print:
                doodleView.printImage(); // Напечатать текущий рисунок
                return true; // Событие меню обработано
        }

        return super.onOptionsItemSelected(item);
    }

    private void saveImage() {
        // Проверить, есть ли у приложения разрешение,
        // необходимое для сохранения
        if (getContext().checkSelfPermission(
                Manifest.permission.WRITE_EXTERNAL_STORAGE) !=
                PackageManager.PERMISSION_GRANTED) {

            // Объяснить, почему понадобилось разрешение
            if (shouldShowRequestPermissionRationale(
                    Manifest.permission.WRITE_EXTERNAL_STORAGE)) {
                AlertDialog.Builder builder =
                        new AlertDialog.Builder(getActivity());

                // Назначить сообщение AlertDialog
                builder.setMessage(R.string.permission_explanation);

                // Добавить кнопку OK в диалоговое окно
                builder.setPositiveButton(android.R.string.ok,
                        new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {
                                // Запросить разрешение
                                requestPermissions(new String[]{
                                                Manifest.permission.WRITE_EXTERNAL_STORAGE},
                                        SAVE_IMAGE_PERMISSION_REQUEST_CODE);
                            }
                        }
                );

                // Отображение диалогового окна
                builder.create().show();
            } else {
                // Запросить разрешение
                requestPermissions(
                        new String[]{Manifest.permission.WRITE_EXTERNAL_STORAGE},
                        SAVE_IMAGE_PERMISSION_REQUEST_CODE);
            }
        } else { // Если разрешение уже имеет разрешение для записи
            doodleView.saveImage(); // Сохранить изображение
        }
    }
    @Override
    public void onRequestPermissionsResult(int requestCode,
                                           String[] permissions, int[] grantResults) {
        // switch выбирает действие в зависимости от того,
        // какое разрешение было запрошено
        switch (requestCode) {
            case SAVE_IMAGE_PERMISSION_REQUEST_CODE:
                if (grantResults[0] == PackageManager.PERMISSION_GRANTED)
                    doodleView.saveImage(); // Сохранить изображение
                return;
        }
    }

    // Метод возвращает объект DoodleView
    public DoodleView getDoodleView() {
        return doodleView;
    }
    // Проверяет, отображается ли диалоговое окно
    public void setDialogOnScreen(boolean visible) {
        dialogOnScreen = visible;
    }
}
