#include <iostream>
using namespace std;

class Matriz{
private:
  int mat[6][6];
  int c=1;

public:
  void llenar();
  string mostrar();
  void llenarPorColumna();
  void llenarInverso();
  string DP();
  string DS();
  string abajoDS();
  string abajoDP();
  void girarDP();
  void girarDS();

};
void Matriz :: llenar(){
  for (int i = 0; i < 6; i++) {
    for (int j = 0; j < 6; j++) {
      mat[i][j] = c++;
    }
  }
}

void Matriz :: llenarInverso(){
  for (int i = 5; i >= 0; i--) {
    for (int j = 5; j >= 0; j--) {
      mat[i][j] = c++;
    }
  }
}

void Matriz :: llenarPorColumna(){
  for (int i = 0; i < 6; i++) {
    for (int j = 0; j < 6; j++) {
      mat[j][i] = c++;
    }
  }
}

string Matriz :: mostrar(){
  string str = "";
  for (int i = 0; i < 6; i++) {
    for (int j = 0; j < 6; j++) {
      str += to_string(mat[i][j])+ " ";
    }
    str += "\n";
  }
  return str;
}

string Matriz :: DP(){
  cout<<"Mostrar diagonal Primaria"<<endl;
  string str = "";
  for (int i = 0; i < 6; i++) {
      str += to_string(mat[i][i])+ " ";
    str += "\n";
  }
  return str;
}

string Matriz :: DS(){
  cout << "Mostrar Diagonal Secundaria" <<endl;
  string str = "";
  int j = 5;
  for (int i = 0; i < 6; i++) {
       str += to_string(mat[i][j])+ " "+ "\n";
       j--;
  }
  return str;
}

string Matriz :: abajoDP(){
  cout<<" Número por debajo de la Diagonal Principal"<<endl;
  string str ="";
  for (int i = 1; i < 6; i++) {
    for (int j = 0; j < i; j++) {
      str += to_string(mat[i][j])+ " "+ "\n";
    }
  }
  return str;
}

string Matriz :: abajoDS(){
  cout<<" Números por debajo de la Diagonal Secundaria "<<endl;
  string str ="";
  int x = 5;
  for (int i = 1; i <= 5; i++) {
    for (int j = x; j <=5  ; j++) {
      str += to_string(mat[i][j])+ " "+ "\n";
    }
    x--;
  }
  return str;
}

void Matriz::girarDP(){
  int tmp=0;
  for (int i = 0; i < 6; i++) {
    for (int j = 1; j < 6; j++) {
      tmp = mat[i][j];
      mat[i][j] = mat[j][i];
      mat[j][i] = tmp;
    }
  }
}

void Matriz::girarDS(){
  int tmp = 0;
  int c = 1;

  for (int i = 0; i < 5; i++) {
    for (int j = 0; j < 5; j++) {
      tmp = mat[i][j];
      mat[i][j] = mat[6-j-1][6-i-1];
      mat[6-j-1][6-i-1] = tmp;
    }
  }
}



int main() {

  Matriz mat;
  mat.llenar();
  //mat.llenarInverso();
//  mat.llenarPorColumna();
  //cout<<mat.DP();
  //cout<<mat.DS();
  //cout<<mat.abajoDP();
  //cout<<mat.abajoDS();
  //mat.girarDP();
  cout<<mat.mostrar() <<endl<<endl;
  mat.girarDS();
  cout<<mat.mostrar();
  cout<<"Done"<<endl;

  return 0;
}
