<h1>Prototype CNC Sender for GRBL 0.9</h1>
<p>We create a prototype for define and execute customs cuts with CNC Plasma Machine. The&nbsp;machine was created with Arduino and GRBL 0.9. This system must execute cuts of daily use in a metallurgical company. These cuts would be defined by indicating their shape and measurements through an elementary user interface.</p>
<p>When we made this machine, we used it with Universal G-Code Sender (an excellent open-source software). Still, it required designing and generating the g-code before executing it. Not practical in daily use of a metallurgical.</p>
<p>The following link is a small sample of the machine and this software: <a href="https://youtu.be/BqKCH0dMwMc">https://youtu.be/BqKCH0dMwMc</a></p>
<h2>Project Scope&nbsp;</h2>
<p>This application is a prototype that allows you to make cuts for everyday use with absolute ease.</p>
<p>With this, we fulfill the first objective that we set ourselves.</p>
<p>In the future, we are going to introduce some features for example:</p>
<ol>
<li>Improve UI/UX for use with touch screen.</li>
<li>Import and execute gcode files.</li>
<li>Automatic axis calibration.</li>
<li>Speed control depending on the thickness of the sheet.</li>
<li>History of cuts made.</li>
</ol>
<p>We will also include a quality control person, so I will also work on bug fixes.</p>
<h2>Limitations</h2>
<p>Since the system works with a plasma, the minimum value of the Z-axis is zero.</p>
<h2>Develop</h2>
<p>This prototype was developed with WinForms C#, .NET Framework 4.6. The machine uses Arduino UNO R3 and GRBL 0.9.</p>
<p>Link for GRBL:&nbsp;<a href="https://github.com/grbl/grbl">https://github.com/grbl/grbl</a></p>
<h2>Team</h2>
<p><strong>Ra&uacute;l Rodr&iacute;guez</strong>, Metallurgist (Robotics Hobbyist)</p>
<ul>
<li>Responsible for the design and construction of the CNC mechanics.&nbsp;</li>
</ul>
<p><strong>Lic. Gonzalo Rodr&iacute;guez</strong>, Sr. Full Stack Developer (Robotics Hobbyist)</p>
<ul>
<li>Responsible for the electrical part of the machine.</li>
<li>Responsible for the complete development of this prototype.</li>
</ul>
<p>&nbsp;</p>
