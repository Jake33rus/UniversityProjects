package com.example.jake.diplom.Activity.ExercisesCategoryActivity.Spina;

import com.example.jake.diplom.R;
/**
 * Created by htcvive on 01.05.2017.
 */

public class Spina {
    private String name;//название упражнения
    private String description;//описание упражнения
    private int imageResourceId;//изображение упражнения
    // Spina - массив с элементами Spina
    public static final Spina[] spinas = {
            new Spina("Гиперэкстензия", "Исходная позиция \n Подойдите к тренажеру, отрегулируйте его высоту под свой рост, а именно: передние валики должны располагаться точно в месте сгиба поясницы и бедер (край верха бедер), " +
                    "нижние валики должны находиться чуть выше ахиллова сухожилия." +
                    " Как только отрегулируете тренажер подобным образом, заведите ступни под нижний опорный валик. " +
                    "Спина находится на одном уровне с линией ног. С этого положения начинается старт \n" +
                    "Выполнение \n"+
                    "Мощно напрягите ягодичные мышцы и “переломитесь” в поясе через тренажер. Слегка наклоните корпус вниз, примерно до угла в 60 градусов и (внимание!) слегка скруглите спину. " +
                    "В нижней точке траектории скрестите руки на груди и плавно (без рывков) поднимите корпус вверх до прямой линии с ногами. " +
                    "Зафиксируйтесь на секунду в таком положении (почувствуйте пиковое сокращение) и снова повторите движение. Техника дыхания: на опускании вдох, на подъеме – выдох.", R.drawable.ic_spinaex1)
    };

    private Spina(String name, String description, int imageResourceId) {
        this.name = name;
        this.description = description;
        this.imageResourceId = imageResourceId;
    }

    public String getName() {
        return name;
    }
    public String getDescription() {return description;}
    public int getImageResourceId() {
        return imageResourceId;
    }
    @Override
    public String toString() {
        return this.name;
    }
}
