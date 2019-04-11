Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Weezer.Visible = True
        GroupBox6.Visible = True
        If RadioButton3.Checked = False Then
            Weezer.Visible = False
            GroupBox6.Visible = False
        End If
    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged
        GroupBox1.Visible = True
        KanyeWest.Visible = True
        If RadioButton13.Checked = False Then
            KanyeWest.Visible = False
            GroupBox1.Visible = False
        End If


    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged
        Kendrick.Visible = True
        GroupBox2.Visible = True
        If RadioButton15.Checked = False Then
            Kendrick.Visible = False
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged
        LilUzi.Visible = True
        GroupBox3.Visible = True
        If RadioButton14.Checked = False Then
            LilUzi.Visible = False
            GroupBox3.Visible = False
        End If
    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged
        LilPeep.Visible = True
        GroupBox4.Visible = True
        If RadioButton16.Checked = False Then
            LilPeep.Visible = False
            GroupBox4.Visible = False
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Blink.Visible = True
        GroupBox5.Visible = True
        If RadioButton1.Checked = False Then
            Blink.Visible = False
            GroupBox5.Visible = False
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        CageElephant.Visible = True
        GroupBox7.Visible = True
        If RadioButton4.Checked = False Then
            CageElephant.Visible = False
            GroupBox7.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Horizon.Visible = True
        GroupBox8.Visible = True

        If RadioButton2.Checked = False Then
            Horizon.Visible = False
            GroupBox8.Visible = False
        End If
    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged
        Skrillex.Visible = True
        GroupBox9.Visible = True
        If RadioButton9.Checked = False Then
            Skrillex.Visible = False
            GroupBox9.Visible = False
        End If
    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged
        Pegboard.Visible = True
        GroupBox10.Visible = True
        If RadioButton12.Checked = False Then
            Pegboard.Visible = False
            GroupBox10.Visible = False
        End If
    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged
        Marshmello.Visible = True
        GroupBox12.Visible = True
        If RadioButton10.Checked = False Then
            Marshmello.Visible = False
            GroupBox12.Visible = False
        End If
    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged
        Dead.Visible = True
        GroupBox11.Visible = True
        If RadioButton11.Checked = False Then
            Dead.Visible = False
            GroupBox11.Visible = False
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Bruno.Visible = True
        GroupBox13.Visible = True
        If RadioButton5.Checked = False Then
            Bruno.Visible = False
            GroupBox13.Visible = False
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        Halsey.Visible = True
        GroupBox14.Visible = True
        If RadioButton7.Checked = False Then
            Halsey.Visible = False
            GroupBox14.Visible = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Rihanna.Visible = True
        GroupBox15.Visible = True
        If RadioButton6.Checked = False Then
            Rihanna.Visible = False
            GroupBox15.Visible = False
        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged
        Weeknd.Visible = True
        GroupBox16.Visible = True
        If RadioButton8.Checked = False Then
            Weeknd.Visible = False
            GroupBox16.Visible = False
        End If
    End Sub

    Private Sub CageElephant_Click(sender As Object, e As EventArgs) Handles CageElephant.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click_1(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Chance the Rapper: Rapper who uses the Gospel style of rap that Kanye used in his early career" + Environment.NewLine + "Travis Scott: Rapper who takes influence from Kanyes Autotune era" + Environment.NewLine + "Kid Cudi: Singer who works with Kanye alot, writes catchy music laced with his depressing lyrics" + Environment.NewLine + "Jay Z: The Hip Hop Mongul who has had a huge career with Kanye West Involved")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "J Cole: Rapper that uses story telling and a slow speaking pace to convey messages in songs" + Environment.NewLine + "JID: A more technical rapper that uses clever rhyme schemes with a quicker flow" + Environment.NewLine + "Ab Soul: Artist signed with Kendrick that raps more about experimental subjects" + Environment.NewLine + "SchoolBoy Q: Rapper signed with Kendrick who raps more about the party life as well as serious issues")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "PlayBoi Carti: Very similar style and if rumors are to believe, they have over 100 songs recorded together yet to be released" + Environment.NewLine + "Young Thug: A extremely influential rapper who gets a lot of discredit for mumbling, however many people view his voice as a instrument" + Environment.NewLine + "Trippie Redd: Raps in a very high raspy voice, is known for being somewhat lyrical and also a singer" + Environment.NewLine + "Future: A trap music giant who has made many smash hits in recent times")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Juice Wrld: Extremely popular rapper/singer who mainly talks about his past relationships" + Environment.NewLine + "Wicca Phase: Artist who worked with Peep and made emotional hip hop that was mainly about substance abuse and failed relationships" + Environment.NewLine + "Suicide Boys: Rap Group that doesn't rap as much about relationships, but has those same styled beats as Peep usually did" + Environment.NewLine + "XXXTentacion: Rapper who died in June 2018 at 20 Years Old, made emotional, but also very aggressive music")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Sum 41: Pop Punk band from the 2000s who wrote many punk anthems" + Environment.NewLine + "Simple Plan: Pop punk with more of a romantic side in most of their songs" + Environment.NewLine + "Green Day: Band that has been around for decades making hits" + Environment.NewLine + "IDLES: British Punk Band that is bringing a more traditional punk sound to the scene")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        MsgBox("Simlar Artists: " + Environment.NewLine + "Dreamers: A newer band that shares that style of writing strange rock ballads that Weezer has always done" + Environment.NewLine + "Pixies: Band that started in late 80's that shares alot of the same influence as Weezer" + Environment.NewLine + "RadioHead: Band that has used many different experimental sounds through their career" + Environment.NewLine + "Car Seat Headrest: A smaller band that uses alot of strange song styles to write interesting songs")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Cold War Kids: Band that uses storytelling in songs to tell inspiring stories" + Environment.NewLine + "AJJ: Singer who uses folk style of rock to tell tales of anxiety, depression, and strange thoughts" + Environment.NewLine + "Arctic Monkeys: Band that is very popular who uses the indie style of rock to write rock anthems" + Environment.NewLine + "Alt-J: Band that uses the indie sound and not many instruments to write catchy songs and keep their unique style")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Ice Nine Kills: Metalcore band that has focused on songs based on books and horror movies in the past" + Environment.NewLine + "I See Stars: Metalcore band that uses alot of electronic music in their sound" + Environment.NewLine + "Oceans Ate Alaska: Band that uses mainly screaming vocals with intricate guitar play" + Environment.NewLine + " I Prevail: Band that uses alot of staples of metalcore as well as performing covers of popular songs")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Diplo: Artist that has exploded in popularity due to great guest features and plenty of hip hop influence" + Environment.NewLine + "DJ Snake: Artist that blew up off his song Turn Down for what, has also made many other trap hits" + Environment.NewLine + "Dillon Francis: DJ with a quirky personality that has some great samples he turns into EDM songs" + Environment.NewLine + "Aero Chord: Smaller EDM DJ that mainly focuses on Drum and Bass while throwing in some Trap style music to mix things up")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Razihel: DJ that mainly does dubstep and trap, uses great vocal artists to make songs catchier" + Environment.NewLine + "Lets Be Friends: Creates huge Dubstep anthems that have stayed popular for years after the songs were created" + Environment.NewLine + "Tristam: Artist that has collaborated with many other DJ's to create songs that blend genres" + Environment.NewLine + "12th Planet: Drum and Bass artist that has collaborated with many big names in the EDM scene.")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Tiesto: Popular DJ that makes house dance music" + Environment.NewLine + "Daft Punk: One of the pioneers of modern edm and still going strong to this day" + Environment.NewLine + "Steve Aoki: DJ that dabbles in many different genres of EDM including trap and house" + Environment.NewLine + "Rogue: Artist that has been with the label Monstercat for quite some time and creates EDM in every genre")
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Wrld: Future bass artist that was one of the pioneers of the genre" + Environment.NewLine + "Martin Garrix: Popular DJ that uses guess artist to gain more views" + Environment.NewLine + "Calvin Harris: Pop DJ known for summer anthems and experimenting with hip hop beats" + Environment.NewLine + "Astronaut: Small edm artist who has made future bass edm in the past")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Ed Sheeran: A singer from England who has a very unique voice that has exploded onto the scene in recent years" + Environment.NewLine + "Justin Timberlake: Known for more then his singer, Timberlake is a can do everything type of person, uses electronic style beats usually in his songs" + Environment.NewLine + "La Roux: A group that sounds right out of the 80's with how they perform their music" + Environment.NewLine + "Shawn Mendez: A singer who uses beats styled around guitars usually")
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Billie Eilish: A up and coming singer who uses more edgier production mixed with lyrics that seem dark but in a playful way" + Environment.NewLine + "Melanie Martinez: A pop singer who has created a whole persona about a little girl singing about the messed up experiences she has" + Environment.NewLine + "Joji: A male singer who uses strange beats that are catchy off of there repetition" + Environment.NewLine + "BlackBear: A male singer who uses R&B style singing, but mixed with depressive lyrics and songs about love lost")
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Beyonce: Considered one of the queens of music in modern times, Beyonce has a tremendous voice and great production" + Environment.NewLine + "Lady Gaga: Mixing in a little weirdness with her songs and music videos, Lady Gaga has become a staple of 2010's pop era" + Environment.NewLine + "Charli XCX: The internet's favorite pop star it would seem, very catchy while performing songs that are styled as 90's pop or something out of the future" + Environment.NewLine + "Taylor Swift: A country turned pop star, but can make hits under each genre")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        MsgBox("Similar Artists: " + Environment.NewLine + "Khalid: Recent Pop/R&B singer with a catchy voice and great songwriting abilities" + Environment.NewLine + "Usher: One of the greatest pop artists during the 2000's, has many hits" + Environment.NewLine + "Frank Ocean: A modern day legend who very rarely releases, but when he does its always a agreed on masterpiece" + Environment.NewLine + "Post Malone: A singer who mixes multiple genres like rock, hip hop, and country")
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Close()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
        RadioButton13.Checked = False
        RadioButton14.Checked = False
        RadioButton15.Checked = False
        RadioButton16.Checked = False
    End Sub
End Class
