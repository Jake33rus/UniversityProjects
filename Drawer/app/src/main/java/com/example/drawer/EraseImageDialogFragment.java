package com.example.drawer;

import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.os.Bundle;
import android.support.v4.app.DialogFragment;
import android.support.v7.app.AlertDialog;

public class EraseImageDialogFragment extends DialogFragment { // Создание и возвращение объекта AlertDialog
    @Override
    public Dialog onCreateDialog(Bundle bundle) {
        AlertDialog.Builder builder =
                new AlertDialog.Builder(getActivity());
        // Назначение сообщения AlertDialog
        builder.setMessage(R.string.message_erase);
        // Добавление кнопки стирания
        builder.setPositiveButton(R.string.button_erase,
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        getDoodleFragment().getDoodleView().clear(); // Очистка
                    }
                }
        );
        // Добавление кнопки стирания
        builder.setNegativeButton(android.R.string.cancel, null);
        return builder.create(); // Возвращает диалоговое окно
    }

    // Получение ссылки на MainActivityFragment
    private MainActivityFragment getDoodleFragment() {
        return (MainActivityFragment) getFragmentManager().findFragmentById(
                R.id.doodleFragment);
    }

    // Сообщает MainActivityFragment, что окно находится на экране
    @Override
    public void onAttach(Context context) {
        super.onAttach(context);
        MainActivityFragment fragment = getDoodleFragment();

        if (fragment != null)
            fragment.setDialogOnScreen(true);
    }

    // Сообщает MainActivityFragment, что окно не отображается
    @Override
    public void onDetach() {
        super.onDetach();
        MainActivityFragment fragment = getDoodleFragment();

        if (fragment != null)
            fragment.setDialogOnScreen(false);
    }

}
