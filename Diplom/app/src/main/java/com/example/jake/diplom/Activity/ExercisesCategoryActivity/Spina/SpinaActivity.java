package com.example.jake.diplom.Activity.ExercisesCategoryActivity.Spina;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.jake.diplom.R;
/**
 * Created by htcvive on 01.05.2017.
 */

public class SpinaActivity extends AppCompatActivity {
    public static final String EXTRA_SPNOM = "spinaNom" ;
    @Override
    protected void onCreate ( Bundle savedInstanceState ) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_spina);
// Получить упражнение на спину
        int spinaNom = (Integer) getIntent().getExtras().get(EXTRA_SPNOM);
        Spina spina = Spina.spinas[spinaNom];
// Заполнить ихображение упражнения на спину
        ImageView photo = (ImageView) findViewById(R.id.photo);
        photo.setImageResource(spina.getImageResourceId());
        photo.setContentDescription(spina.getName());
// Заполнение наименования упражнения на спину
        TextView name = (TextView) findViewById(R.id.name);
        name.setText(spina.getName());
// Заполнение описания упражнения на спину
        TextView description = (TextView) findViewById(R.id.description);
        description.setText(spina.getDescription());
    }
}