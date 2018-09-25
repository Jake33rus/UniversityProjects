package com.example.jake.diplom.Activity;
import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;
import com.example.jake.diplom.Activity.ExercisesCategoryActivity.Exercises;
import com.example.jake.diplom.Activity.Menu.Author;
import com.example.jake.diplom.Activity.Menu.Calculaters.Calculaters;
import com.example.jake.diplom.R;

public class TopActivity extends AppCompatActivity implements View.OnClickListener {
    private ImageView exIv, calIv, encyIv, auIv;
    private TextView exTv, calTv, encyTv, auTv;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_top);
        initViews();

    }
    private void initViews(){
        exIv = (ImageView) findViewById(R.id.im_exe);
        exTv = (TextView) findViewById(R.id.tv_exe);
        exIv.setOnClickListener(this);
        exTv.setOnClickListener(this);
        calIv = (ImageView)findViewById(R.id.im_cal);
        calTv = (TextView)findViewById(R.id.tv_cal);
        calIv.setOnClickListener(this);
        calTv.setOnClickListener(this);
        encyIv = (ImageView)findViewById(R.id.im_ency);
        encyTv = (TextView)findViewById(R.id.tv_ency);
        auIv = (ImageView)findViewById(R.id.im_author);
        auTv = (TextView)findViewById(R.id.tv_author);
        auIv.setOnClickListener(this);
        auTv.setOnClickListener(this);
    }
    @Override
    public void onClick(View view) {
        if (view.equals(exTv) || view.equals(exIv)) {
            Intent intent = new Intent(this, Exercises.class);
            startActivity(intent);
        }
        if (view.equals(auIv)||view.equals(auTv)){
            Intent intent = new Intent(this, Author.class);
            startActivity(intent);
        }
        if (view.equals(calIv)||view.equals(calTv)){
            Intent intent = new Intent(this, Calculaters.class);
            startActivity(intent);
        }
    }
}
