package com.example.jake.diplom.Activity.ExercisesCategoryActivity.Grud;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.jake.diplom.R;

/**
 * Created by htcvive on 06.05.2017.
 */

public class GrudActivity extends AppCompatActivity {
    public static final String EXTRA_SPNOM = "GrudNom" ;
    @Override
    protected void onCreate ( Bundle savedInstanceState ) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_grud);
// Получить упражнение на грудь
        int GrudNom = (Integer) getIntent().getExtras().get(EXTRA_SPNOM);
        Grud grud = Grud.gruds[GrudNom];
// Заполнить ихображение упражнения на грудь
        ImageView photo = (ImageView) findViewById(R.id.photo);
        photo.setImageResource(grud.getImageResourceId());
        photo.setContentDescription(grud.getName());
// Заполнение наименования упражнения на спину
        TextView name = (TextView) findViewById(R.id.name);
        name.setText(grud.getName());
// Заполнение описания упражнения на спину
        TextView description = (TextView) findViewById(R.id.description);
        description.setText(grud.getDescription());
    }
}

