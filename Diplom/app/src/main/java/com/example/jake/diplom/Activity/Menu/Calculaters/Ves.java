package com.example.jake.diplom.Activity.Menu.Calculaters;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.example.jake.diplom.R;


public class Ves extends AppCompatActivity {
    Button btnDel, btnScet;
    EditText emp, pov, otv;
    public double mp, vs, pv;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ves);
        initViews();
        setClickBtnDel();
        setClickBtnScet();
    }

    private void initViews() {
        btnDel = (Button) findViewById(R.id.delBtn);
        btnScet = (Button) findViewById(R.id.scBtn);
        pov = (EditText) findViewById(R.id.ePov);
        emp = (EditText) findViewById(R.id.eMP);
        otv = (EditText) findViewById(R.id.rslt);
    }
    private void setClickBtnDel(){
        btnDel.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                emp.setText("");
                pov.setText("");
                otv.setText("");
            }
        });
    }
    private void setClickBtnScet(){
        btnScet.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                mp = Double.parseDouble(emp.getText().toString());
                pv = Double.parseDouble(pov.getText().toString());
                vs=30*mp/(pv+30);
                otv.setText(""+vs);
            }
        });
    }
}
