package com.example.prime_distribution_graph;


import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Color;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.github.mikephil.charting.animation.Easing;
import com.github.mikephil.charting.charts.LineChart;
import com.github.mikephil.charting.components.Description;
import com.github.mikephil.charting.components.XAxis;
import com.github.mikephil.charting.components.YAxis;
import com.github.mikephil.charting.data.Entry;
import com.github.mikephil.charting.data.LineData;
import com.github.mikephil.charting.data.LineDataSet;

import java.util.ArrayList;
import java.util.List;
import java.lang.Math;

public class MainActivity extends AppCompatActivity {
    EditText editText1, editText2;
    Button button;
    String start;
    String end;
    int x,y;
    float a,b;

    LineChart lineChart;

    public int count_prime2(int n, int length)//counting method how many prime number in interval
    {

        int num=0;
        for (int i=n;i<n+length;i++)
        {
            if (i<=1)
            {
                continue;
            }
            int sum=0;
            for (int j=2;j<=Math.sqrt(i);j++)
            {
                if (i%j==0)
                {sum=sum+1;
                    break;
                }
            }
            if (sum==0)
            {
                num=num+1;
            }

        }
        return num;

    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        editText1 = findViewById(R.id.start);
        editText2 = findViewById(R.id.end);
        lineChart = findViewById(R.id.chart);
        button = findViewById(R.id.button);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                start = editText1.getText().toString();
                end = editText2.getText().toString();
                x = Integer.parseInt(start);
                y = Integer.parseInt(end);


                List<Entry> entries = new ArrayList<>();

                for (int i = 1; i < y+1; i++) {
                    a=(float)count_prime2(x * (i - 1), x )/x;
                    b=a*100;
                    entries.add(new Entry(i * x, b));
                }

                LineDataSet lineDataSet = new LineDataSet(entries, "ratio");
                lineDataSet.setLineWidth(2);
                lineDataSet.setCircleRadius(6);
                lineDataSet.setCircleColor(Color.parseColor("#FFA1B4DC"));
                lineDataSet.setCircleColorHole(Color.BLUE);
                lineDataSet.setColor(Color.parseColor("#FFA1B4DC"));
                lineDataSet.setDrawCircleHole(true);
                lineDataSet.setDrawCircles(true);
                lineDataSet.setDrawHorizontalHighlightIndicator(false);
                lineDataSet.setDrawHighlightIndicators(false);
                lineDataSet.setDrawValues(false);

                LineData lineData = new LineData(lineDataSet);
                lineChart.setData(lineData);

                XAxis xAxis = lineChart.getXAxis();
                xAxis.setPosition(XAxis.XAxisPosition.BOTTOM);
                xAxis.setTextColor(Color.BLACK);
                xAxis.enableGridDashedLine(8, 24, 0);

                YAxis yLAxis = lineChart.getAxisLeft();
                yLAxis.setTextColor(Color.BLACK);

                YAxis yRAxis = lineChart.getAxisRight();
                yRAxis.setDrawLabels(false);
                yRAxis.setDrawAxisLine(false);
                yRAxis.setDrawGridLines(false);

                Description description = new Description();
                description.setText("");

                lineChart.setDoubleTapToZoomEnabled(false);
                lineChart.setDrawGridBackground(false);
                lineChart.setDescription(description);
                lineChart.animateY(2000, Easing.EasingOption.EaseInCubic);
                lineChart.invalidate();
            }


        });
    }


}
