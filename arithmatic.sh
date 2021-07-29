
read -p "Please insert a number" number
if (($number % 2 == 0))
then
echo 'The number is even'
elif (($number % 2 == 1))
then
echo 'The number is odd'
fi
echo
#===================================================

 #'w.a.p . display the grade of a student based on the marks entered. If marks below 40, grade is F;
 #if mark is between 41-50, grade is D, if mark is between 51-60,
 #grade is C; if mark is between 61-70, grade is B and if mark is greater than 70 grade is A.\

read -p "Please insert your school grade" grade
if (($grade <= 40))
then
echo 'grade is F'
elif (($grade >= 41)) && (($grade <= 50))
then
echo 'grade is D'
elif (($grade >= 51)) && (($grade <= 60))
then
echo 'grade is C'
elif (($grade >= 61)) && (($grade <= 70))
then
echo 'grade is B'
elif (($grade > 70))
then
echo 'grade is A'
fi