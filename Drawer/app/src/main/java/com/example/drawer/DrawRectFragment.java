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

public class DrawRectFragment extends DialogFragment {
    @Override
    public Dialog onCreateDialog(Bundle bundle) {
        AlertDialog.Builder builder =
                new AlertDialog.Builder(getActivity());
        View drawCircleDialogView =
                getActivity().getLayoutInflater().inflate(
                        R.layout.fragment_draw_rect, null);
        builder.setView(drawCircleDialogView); // Добавление GUI
        builder.setTitle(R.string.title_draw_rect);
        final DoodleView doodleView = getDoodleFragment().getDoodleView();
        final EditText right = (EditText) drawCircleDialogView.findViewById(R.id.setRectRightEditText);
        final EditText left = (EditText) drawCircleDialogView.findViewById(R.id.setRectLeftEditText);
        final EditText top = (EditText) drawCircleDialogView.findViewById(R.id.setRectTopEditText);
        final EditText bottom = (EditText) drawCircleDialogView.findViewById(R.id.setRectRBottomsEditText);

        builder.setPositiveButton(R.string.button_set_coordinates,
                new DialogInterface.OnClickListener() {
                    public void onClick(DialogInterface dialog, int id) {
                        //обработка исключения при пустых значениях
                        try {
                                doodleView.drawRect(Float.parseFloat(right.getText().toString()),
                                        Float.parseFloat(left.getText().toString()),
                                        Float.parseFloat(top.getText().toString()),
                                        Float.parseFloat(bottom.getText().toString()));
                        }
                        catch (Exception e) {}
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
