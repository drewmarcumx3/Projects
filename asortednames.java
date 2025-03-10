import javax.swing.JOptionPane

public class SortedNames{

public static void main (String[] args ) {

String name1;
String name2;
String name3;

String output = "";

name1 = JOptionPane.showInputDialog( "Please enter name 1" );
name2 = JOptionPane.showInputDialog( "Please enter name 2" );
name3 = JOptionPane.showInputDialog( "Please enter name 3" );

if (name1.compareToIgnoreCase( name2 ) < 0 && name1.compareToIgnoreCase( name3 ) < 0 ) {
output += name1 + "\n";
if (name2.compareToIgnoreCase( name3 ) < 0){
output += name2 + "\n";
output += name3 + "\n";
} else{
output += name3 + "\n";
output += name2 + "\n";
}
} else if( name2.compareToIgnoreCase( name1 ) < 0 && name2.compareToIgnoreCase( name3 ) < 0 ) {
output += name2 + "\n";
if(name1.compareToIgnoreCase( name3 ) < 0){
output += name1 + "\n";
output += name3 + "\n";
}else{
output += name3 + "\n";
output += name1 + "\n";
}
} else if( name3.compareToIgnoreCase( name2 ) < 0 && name3.compareToIgnoreCase( name1 ) < 0 ) {
output += name3 + "\n";
if(name2.compareToIgnoreCase( name1 ) < 0){
output += name2 + "\n";
output += name1 + "\n";
} else{
output += name1 + "\n";
output += name2 + "\n";
}
}
JOptionPane.showMessageDialog( null, output );

System.exit(0);
}
}
