package com.example.jake.diplom.Activity.Menu.Calculaters;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.example.jake.diplom.R;

/**
 * Created by htcvive on 08.05.2017.
 */

public class MP extends AppCompatActivity {
    Button btnDel, btnScet;
    EditText ves, pov, otv;
    public double mp, vs, pv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mp);
        initViews();
        setClickBtnDel();
        setClickBtnScet();
    }

    private void initViews() {
        btnDel = (Button) findViewById(R.id.btnDel);
        btnScet = (Button) findViewById(R.id.btnSc);
        ves = (EditText) findViewById(R.id.editVes);
        pov = (EditText) findViewById(R.id.editPov);
        otv = (EditText) findViewById(R.id.result);
    }
    private void setClickBtnDel(){
        btnDel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ves.setText("");
                pov.setText("");
                otv.setText("");
            }
        });
    }
    private void setClickBtnScet(){
        btnScet.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                vs = Double.parseDouble(ves.getText().toString());
                pv = Double.parseDouble(pov.getText().toString());
                mp=vs/(1.0278-0.0278*pv);
                otv.setText(""+mp);
            }
        });
    }
}