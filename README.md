# beady
串珠確認檔
修改方向: 燈光要亮一些、再增加一顆旁觀者camera、房間窗戶低一點(可以加一扇門)

## 2023/5/25會議紀錄
內積外積在空間中取得座標
HOW to get旋轉角度? :
1. ![acos反餘弦](http://tw.gitbook.net/c_standard_library/c_function_acos.html) 得到弧度
2. atan2()
逆時針還是順時針? :
外積

![image](https://github.com/vr-beady/beady/assets/131236716/0d896f6b-ca15-4dc7-9960-ab2b5bcec489)
```p=!
//內積範例(投影量)
ArrayList<PVector>pt;
void setup(){
  size(500, 500);
  pt = new ArrayList<PVector>();
}
void draw(){
  background(#FFFFF2);
  for(PVector p : pt){
    stroke(0);
    ellipse(p.x, p.y, 10, 10);
    line(p.x, p.y, pt.get(0).x, pt.get(0).y);
  }
  if(pt.size()>=2){
    PVector p0 = pt.get(0), p1 = pt.get(1), p = new PVector(mouseX, mouseY);
    stroke(#FF0000);
    line(p.x, p.y, p0.x, p0.y);
    PVector v1 = PVector.sub(p1,p0).normalize();
    PVector v2 = PVector.sub(p,p0);
    float len = PVector.dot(v2,v1);
    println(len);
    PVector p22 = PVector.add(p0, v1.mult(len));
    line(p0.x, p0.y, p22.x, p22.y);
    line(p22.x, p22.y, p.x, p.y);
  }
}
void mousePressed(){
  pt.add(new PVector(mouseX, mouseY));
}
```
