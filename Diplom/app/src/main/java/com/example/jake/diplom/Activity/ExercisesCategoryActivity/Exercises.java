package com.example.jake.diplom.Activity.ExercisesCategoryActivity;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import com.example.jake.diplom.Activity.ExercisesCategoryActivity.Grud.GrudCategoryActivity;
import com.example.jake.diplom.Activity.ExercisesCategoryActivity.Spina.SpinaCategoryActivity;
import com.example.jake.diplom.R;

/**
 * Created by htcvive on 01.05.2017.
 */
public class Exercises extends AppCompatActivity implements View.OnClickListener {
    private ImageView imSh, imPl, imPrpl, imSp, imGr, imTr, imBc, imPr, imBd, imGo;
    private TextView tvSh, tvPl, tvPrpl, tvSp, tvGr, tvTr, tvBc, tvPr, tvBd, tvGo;
    @Override
        protected void onCreate(Bundle savedInstanceState) {
            super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_exercises);
        initViewsSp(); initViewsBc(); initViewsBd(); initViewsGo(); initViewsGr(); initViewsPl(); initViewsPr(); initViewsPrpl(); initViewsSh(); initViewsSp(); initViewsTr();
    }
    private void initViewsSp(){
        imSp = (ImageView) findViewById(R.id.im_spina);
        tvSp = (TextView) findViewById(R.id.tv_spina);
        imSp.setOnClickListener(this);
        tvSp.setOnClickListener(this);

    }

    private  void initViewsSh(){
        imSh = (ImageView) findViewById(R.id.im_sheya);
        tvSh = (TextView) findViewById(R.id.tv_sheya);
        imSh.setOnClickListener(this);
        tvSh.setOnClickListener(this);
    }
    private void initViewsPl(){
        imPl = (ImageView) findViewById(R.id.im_plechi);
        tvPl = (TextView) findViewById(R.id.tv_plechi);
        imPl.setOnClickListener(this);
        tvPl.setOnClickListener(this);
    }
    private void initViewsPrpl(){
        imPrpl = (ImageView) findViewById(R.id.im_predpl);
        tvPrpl = (TextView) findViewById(R.id.tv_predpl);
        imPrpl.setOnClickListener(this);
        tvPrpl.setOnClickListener(this);
    }
    private void initViewsGr(){
        imGr = (ImageView) findViewById(R.id.im_grud);
        tvGr = (TextView) findViewById(R.id.tv_grud);
        imGr.setOnClickListener(this);
        tvGr.setOnClickListener(this);
    }
    private void initViewsTr(){
        imTr = (ImageView) findViewById(R.id.im_triceps);
        tvTr = (TextView) findViewById(R.id.tv_triceps);
        imTr.setOnClickListener(this);
        tvTr.setOnClickListener(this);
    }
    private void initViewsBc(){
        imBc = (ImageView) findViewById(R.id.im_biceps);
        tvBc = (TextView) findViewById(R.id.tv_biceps);
        imBc.setOnClickListener(this);
        tvBc.setOnClickListener(this);
    }
    private void initViewsPr(){
        imPr = (ImageView) findViewById(R.id.im_press);
        tvPr = (TextView) findViewById(R.id.tv_press);
        imPr.setOnClickListener(this);
        tvPr.setOnClickListener(this);
    }
    private void initViewsBd(){
        imBd = (ImageView) findViewById(R.id.im_bedro);
        tvBd = (TextView) findViewById(R.id.tv_bedro);
        imBd.setOnClickListener(this);
        tvBd.setOnClickListener(this);
    }
    private void initViewsGo(){
        imGo = (ImageView) findViewById(R.id.im_golen);
        tvGo = (TextView) findViewById(R.id.tv_golen);
        imGo.setOnClickListener(this);
        tvGo.setOnClickListener(this);
    }

    @Override
    public void onClick(View view) {
        if (view.equals(imSp) || view.equals(tvSp))  {
            Intent intent = new Intent(this, SpinaCategoryActivity.class);
            this.startActivity(intent);
        }
        if (view.equals(imGr) || view.equals(tvGr))  {
            Intent intent = new Intent(this, GrudCategoryActivity.class);
            this.startActivity(intent);
        }
    }
}

