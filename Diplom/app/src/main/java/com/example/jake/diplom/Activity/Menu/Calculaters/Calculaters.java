package com.example.jake.diplom.Activity.Menu.Calculaters;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;

import com.example.jake.diplom.R;

/**
 * Created by htcvive on 01.05.2017.
 */

public class Calculaters extends AppCompatActivity implements View.OnClickListener{
    private Button btnMP, btnPov, btnVes;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_calculaters);
        initViews();
    }
    private void initViews(){
        btnMP = (Button)findViewById(R.id.culcMP);
        btnMP.setOnClickListener(this);
        btnPov=(Button)findViewById(R.id.btnCulcPov);
        btnPov.setOnClickListener(this);
        btnVes=(Button)findViewById(R.id.btnCulcVes);
        btnVes.setOnClickListener(this);
    }

    @Override
    public void onClick(View v) {
        if(v.equals(btnVes)){
            Intent intent = new Intent(this, Ves.class);
            startActivity(intent);
        }
        if(v.equals(btnPov)){
            Intent intent = new Intent(this, Povtor.class);
            startActivity(intent);
        }
        if(v.equals(btnMP)){
            Intent intent = new Intent(this, MP.class);
            startActivity(intent);
        }
    }
}
