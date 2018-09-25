package com.example.jake.diplom.Activity.ExercisesCategoryActivity.Grud;

import android.app.ListActivity;
import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ListView;

/**
 * Created by htcvive on 06.05.2017.
 */

public class GrudCategoryActivity extends ListActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        ListView listGrud = getListView();
        ArrayAdapter<Grud> listAdapter = new ArrayAdapter<Grud>(
                this,
                android.R.layout.simple_list_item_1,
                Grud.gruds);
        listGrud.setAdapter(listAdapter);
    }
    @Override
    public void onListItemClick (ListView listView , View itemView , int position , long id ) {
        Intent intent = new Intent ( GrudCategoryActivity.this , GrudActivity.class );
        intent.putExtra ( GrudActivity.EXTRA_SPNOM, (int) id);
        startActivity(intent);
    }
}

