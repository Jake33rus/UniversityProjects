package com.example.drawer;

import android.app.Dialog;
import android.content.Context;
import android.content.DialogInterface;
import android.net.Uri;
import android.os.Bundle;
import android.support.v4.app.DialogFragment;
import android.support.v4.app.Fragment;
import android.support.v7.app.AlertDialog;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.EditText;


public class DrawCircleFragment extends DialogFragment {
    @Override
    public Dialog onCreateDialog(Bundle bundle) {
        AlertDialog.Builder builder =
                new AlertDialog.Builder(getActivity());
        View drawCircleDialogView =
                getActivity().getLayoutInflater().inflate(
                        R.layout.fragment_draw_circle, null);
        builder.setView(drawCircleDialogView); // Добавление GUI
        builder.setTitle(R.string.title_draw_circle_dialog);
        final DoodleView doodleView = getDoodleFragment().getDoodleView();
        final EditText x = (EditText) drawCircleDialogView.findViewById(R.id.setCircleXEditText);
        final EditText y = (EditText) drawCircleDialogView.findViewById(R.id.setCircleYEditText);
        final EditText rad = (EditText) drawCircleDialogView.findViewById(R.id.setCircleRadiusEditText);
        builder.setPositiveButton(R.string.button_set_coordinates,
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        try {
                            doodleView.drawCircle(Float.parseFloat(x.getText().toString()), Float.parseFloat(y.getText().toString()), Float.parseFloat(rad.getText().toString()));
                        } catch (Exception e) {
                        }
                    }
                });
        return builder.create();
    }
    private MainActivityFragment getDoodleFragment() {
        return (MainActivityFragment) getFragmentManager().findFragmentById(
                R.id.doodleFragment);
    }
    @Override
    public void onAttach(Context context) {
        super.onAttach(context);
        MainActivityFragment fragment = getDoodleFragment();

        if (fragment != null)
            fragment.setDialogOnScreen(true);
    }
    @Override
    public void onDetach() {
        super.onDetach();
        MainActivityFragment fragment = getDoodleFragment();

        if (fragment != null)
            fragment.setDialogOnScreen(false);
    }
}
