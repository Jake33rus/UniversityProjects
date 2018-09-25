package com.example.jake.diplom.Activity.ExercisesCategoryActivity.Spina;

import android.app.ListActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ListView;

/**
 * Created by htcvive on 01.05.2017.
 */

public class SpinaCategoryActivity extends ListActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        ListView listSpinas = getListView();
        ArrayAdapter<Spina> listAdapter = new ArrayAdapter<Spina>(
                this,
                android.R.layout.simple_list_item_1,
                Spina.spinas);
        listSpinas.setAdapter(listAdapter);
    }
    @Override
    public void onListItemClick (ListView listView , View itemView , int position , long id ) {
        Intent intent = new Intent ( SpinaCategoryActivity.this , SpinaActivity.class );
        intent.putExtra ( SpinaActivity.EXTRA_SPNOM, (int) id);
        startActivity(intent);
    }
}
