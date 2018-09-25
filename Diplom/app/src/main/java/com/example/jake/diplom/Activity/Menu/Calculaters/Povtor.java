package com.example.jake.diplom.Activity.Menu.Calculaters;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.example.jake.diplom.R;


public class Povtor extends AppCompatActivity {
    Button btnDel, btnScet;
    EditText ves, maxp, otv;
    public double mp, vs, pv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_povtor);
        initViews();
        setClickBtnDel();
        setClickBtnScet();
    }

    private void initViews() {
        btnDel = (Button) findViewById(R.id.bDel);
        btnScet = (Button) findViewById(R.id.bSc);
        ves = (EditText) findViewById(R.id.editVs);
        maxp = (EditText) findViewById(R.id.editMp);
        otv = (EditText) findViewById(R.id.res);
    }
    private void setClickBtnDel(){
        btnDel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ves.setText("");
                maxp.setText("");
                otv.setText("");
            }
        });
    }
    private void setClickBtnScet(){
        btnScet.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                vs = Double.parseDouble(ves.getText().toString());
                mp = Double.parseDouble(maxp.getText().toString());
                pv=(mp-vs)/vs/0.033;
                otv.setText(""+pv);
            }
        });
    }
}
