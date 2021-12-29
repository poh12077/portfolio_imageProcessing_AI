package report1;

//swing,awt are working on javaSE 1.8
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;



	class functionSet{
		
		
		  static int y[] = {0,0,0,0,0,0,0,0,0,0};
		  static float y1[] = {0,0,0,0,0,0,0,0,0,0};
		  static int y2[] = {0,0,0,0,0,0,0,0,0,0};

			static String arr1[] = new String [10];
			static String arr2[] = new String [10];
			static String arr3[] = new String [10];

		
			
			
		public static int primeProducer(int n){
			//produce n numberth prime number
					//time complexity is O(n^2)
					
					int count=0;
					int prime=0;
						
									
						for (int i=2;;i++)
						{	
							if(n<1) {
								break;
							}
							
							int sum=0;
							for (int j=2;j<=Math.sqrt(i);j++)
							{
								if (i%j==0)
								{	
									sum=sum+1;
								break;
									}
							}
							
							if (sum==0)
							{		
							 count=count+1;
							 prime=i;
							}
						
							if (count==n) {
								break;
							}
						}
							
					
						return prime;
					}
				
		
		
		
		
		public static int fibonacci(int n) {
			//produce numberth fibonacci number
			
				int a=1;
				int b=1;
				int c=0;
							
				for (int i=0;i<n;i++) {
				c= a + b;
				a=b;
				b=c;
				
				
				}
				return c;
		}
		
		
		
		
		
		public static void count(int k) {
			//count how many each digit(0 ~ 9) in the prime number except last digit.
				int x=0;
				
				
				
				
				if (k<10) {
					k=k*10;
				}
				
				k=k/10;
				
				while(true) {
					
				
				//int x=0;
				
				x=k%10;
				

				if(k==0) {
					break;
				}
			
				
				k=k/10;
			
			switch(x) {
				case 0: y[0]=y[0]+1;
				break;
				case 1: y[1]=y[1]+1;
				break;
				case 2: y[2]=y[2]+1;
				break;
				case 3: y[3]=y[3]+1;
				break;
				case 4: y[4]=y[4]+1;
				break;
				case 5: y[5]=y[5]+1;
				break;
				case 6: y[6]=y[6]+1;
				break;
				case 7: y[7]=y[7]+1;
				break;
				case 8: y[8]=y[8]+1;
				break;
				case 9: y[9]=y[9]+1;
				break;
			}
			
			}
			}
		
		
		
		
		
		public static void count0(int k) {
			//count how many each digit(0 ~ 9) in the prime number .
				
			
			
				while(true) {
					
				
				int x=0;
				
				x=(int)k%10;
				

				if(k==0) {
					break;
				}
			
				
				k=k/10;
			
			switch(x) {
				case 0: y[0]=y[0]+1;
				break;
				case 1: y[1]=y[1]+1;
				break;
				case 2: y[2]=y[2]+1;
				break;
				case 3: y[3]=y[3]+1;
				break;
				case 4: y[4]=y[4]+1;
				break;
				case 5: y[5]=y[5]+1;
				break;
				case 6: y[6]=y[6]+1;
				break;
				case 7: y[7]=y[7]+1;
				break;
				case 8: y[8]=y[8]+1;
				break;
				case 9: y[9]=y[9]+1;
				break;
			}
			
			}
			}
		
		
		
		
		//this method print ratio of each digit in the prime number
		public static void ratioCalculator(int[] y) {
			
			int m;
			
			m=y[0]+y[1]+y[2]+y[3]+y[4]+y[5]+y[6]+y[7]+y[8]+y[9];
			
			for (int i=0;i<10;i++)
			{
				y1[i]=(float)y[i]/m*100;

			}
			
			
		}
		
		
		
		
		
		//this method calculate ratio of each digit in the prime number
		public static void ratioCalculator1() {
			
			int m;
			
			m=y[0]+y[1]+y[2]+y[3]+y[4]+y[5]+y[6]+y[7]+y[8]+y[9];
			
			for (int i=0;i<10;i++)
			{
				y1[i]=(float)y[i]/m*100;

			}
			
			
		}
		
		
		
		
		
		
		//this method calculates order of digits according to size.
		public static void orderCalculator() {
			
			int z[] = {0,0,0,0,0,0,0,0,0,0};
			
			for (int i1=0;i1<10;i1++) {
				z[i1]=y[i1];
			}
			
			int a,b;
			int c=1;
			
			for (int g=0;g<10;g++) {
				a=g;
				b=z[g];
				for(int h=0;h<10;h++) 
				{
					if (b<z[h]) {
						a=h;
						b=z[h];								
					}
					
				}
				z[a]=-1;
				
				y2[a]=c;
				c+=1;
				//System.out.print(a + "  ");
			}
	  //System.out.println();
			
		}
		
		
		
		
		
		
		static void convertor() {
			
			for ( int i=0;i<10;i++) {
				
			arr1[i]= Integer.toString(y[i]);
			}
		}
		
			
	
		
		
		
	static void convertor1() {
		
		for ( int i=0;i<10;i++) {
			
		arr2[i]= Float.toString(y1[i]);
		}
	}
	
	
	
	
	
static void convertor2() {
		
		for ( int i=0;i<10;i++) {
			
		arr3[i]= Float.toString(y2[i]);
		}
	}
	

	
		}
		
	
	
	
	
	
	class frame extends JFrame{
		
		
		int x1,x2;
		String s1,s2;
		
		
		
		public frame() {
			
			setTitle("frequency distribution of digits in the prime number");
			setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
			
			Container contentPane = getContentPane();
			contentPane.setBackground(Color.GREEN);
			contentPane.setLayout(new FlowLayout());
			
			JLabel label1 = new JLabel("only integer ");
			JButton button1 = new JButton("prime number");
			JButton button2 = new JButton("fibonacci number");

			JTextField textfield1 = new JTextField(10);
			JTextField textfield2 = new JTextField(10);
			JTextArea textarea1 = new JTextArea(32,90);
			
			
			
			
			class prime implements ActionListener{
				public void actionPerformed(ActionEvent e) {
					
					
					
					textfield1.addActionListener(new ActionListener() {
						public void actionPerformed(ActionEvent e) {
							
							JTextField t = (JTextField)e.getSource();
												
							s1=t.getText();		
							x1=Integer.parseInt(s1);
							
							for( int i=1;i<=x1;i++) {
								
								x2=functionSet.primeProducer(i);
								functionSet.count(x2);
								functionSet.ratioCalculator1();
								functionSet.orderCalculator();

								functionSet.convertor();
								functionSet.convertor1();
								functionSet.convertor2();


								}
							
							
							textarea1.append( x2 + " : ");
							textarea1.append(  " \n ");

							
							
							textarea1.append("number     : " );
							for (int i=0;i<10;i++) {
							textarea1.append( functionSet.arr1[i] + "                       ");
							}
							textarea1.append(  " \n ");
							
							
							
							
							textarea1.append("proportion : " );
							for (int i=0;i<10;i++) {
								textarea1.append( functionSet.arr2[i] + "            ");
								}
								textarea1.append(  " \n ");

								
								
								
								
							textarea1.append("order          : " );
								for (int i=0;i<10;i++) {
									textarea1.append( functionSet.arr3[i] + "                        ");
									}
									textarea1.append(  " \n ");

									textarea1.append(  " \n ");

								
									
								for(int i=0;i<10;i++) {
									functionSet.y[i]=0;
									functionSet.y1[i]=0;
									functionSet.y2[i]=0;
								}
								  
							
							
							
							t.setText("");
						}
					});
					
				}
				
			}
			
			
			
			
			
			class fibonacci implements ActionListener{
				public void actionPerformed(ActionEvent e) {
					//JButton b = (JButton)e.getSource();
					
					
					textfield1.addActionListener(new ActionListener() {
						public void actionPerformed(ActionEvent e) {
							JTextField t = (JTextField)e.getSource();
							
																			
							s1=t.getText();		
							x1=Integer.parseInt(s1);
							
							for( int i=1;i<=x1;i++) {
								
								x2=functionSet.fibonacci(i);
								functionSet.count0(x2);
								functionSet.ratioCalculator1();
								functionSet.orderCalculator();

								functionSet.convertor();
								functionSet.convertor1();
								functionSet.convertor2();


								}
							
							
							textarea1.append( x2 + " : ");
							textarea1.append(  " \n ");

							
							
							textarea1.append("number     : " );
							for (int i=0;i<10;i++) {
							textarea1.append( functionSet.arr1[i] + "                       ");
							}
							textarea1.append(  " \n ");
							
							
							
							
							textarea1.append("proportion : " );
							for (int i=0;i<10;i++) {
								textarea1.append( functionSet.arr2[i] + "            ");
								}
								textarea1.append(  " \n ");

								
								
								
							textarea1.append("order          : " );
								for (int i=0;i<10;i++) {
									textarea1.append( functionSet.arr3[i] + "                        ");
									}
									textarea1.append(  " \n ");

									textarea1.append(  " \n ");

								
								for(int i=0;i<10;i++) {
									functionSet.y[i]=0;
									functionSet.y1[i]=0;
									functionSet.y2[i]=0;
								}
								  
							
							
							
							t.setText("");
						}
					});
					
				}
				
			}
			
			
			
			prime l1 = new prime();
			fibonacci l0 = new fibonacci();

			
			button1.addActionListener(l1);
			button2.addActionListener(l0);

			contentPane.add(label1);
			contentPane.add(textfield1);
			//contentPane.add(textfield2);
			contentPane.add(button1);
			contentPane.add(button2);

			contentPane.add(new JScrollPane(textarea1));
			
			
						
			setSize(1200,650);
			setVisible(true);
		}
		
	}



public class finalReport {

	
	
	public static void main (String[] args) {
	
		frame frame1 = new frame();
	}
	
	
}