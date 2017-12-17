<body>
<?php
for ($i = 1; $i<= 9; $i++){
    for ($j = 1; $j <= 5; $j++){
        if ($i == 1 || $i== 5 || $i== 9 || ($i>=2 && $i < 5 && $j == 1) || ($i>=6 && $i <= 8 && $j == 5)){
            echo "<button style='background-color: blue'>1</button>";
        }
        else{
            echo "<button>0</button>";
        }
    }
    echo "<br>";
}?>
</body>