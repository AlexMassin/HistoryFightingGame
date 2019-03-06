Imports System.Drawing.Point
Public Class Play5
    Dim Redmoney As Integer = 100
    Dim Bluemoney As Integer = 100
    Dim RedKnightFirst As Boolean = False
    Dim RedKnightSecond As Boolean = False
    Dim RedKnightThird As Boolean = False
    Dim BlueKnightFirst As Boolean = False
    Dim BlueKnightSecond As Boolean = False
    Dim BlueKnightThird As Boolean = False
    Dim Red1 As Boolean = False
    Dim Red2 As Boolean = False
    Dim Red3 As Boolean = False
    Dim blue1 As Boolean = False
    Dim blue2 As Boolean = False
    Dim blue3 As Boolean = False
    Private Sub lblFight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFight.Click
        Static Chealth As Integer = 0
        Static Phealth As Integer = 0
        Static BlueSol1 As Integer = 0
        Static BlueSol2 As Integer = 0
        Static BlueSol3 As Integer = 0
        Static RedSol1 As Integer = 0
        Static RedSol2 As Integer = 0
        Static RedSol3 As Integer = 0
        Static RedKnight1 As Integer = 0
        Static RedKnight2 As Integer = 0
        Static RedKnight3 As Integer = 0
        Static BlueKnight1 As Integer = 0
        Static BlueKnight2 As Integer = 0
        Static BlueKnight3 As Integer = 0

        Randomize()
        Dim randomBlueHealth As Integer
        Dim randomRedHealth As Integer
        If chkBlueSol1.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = False And BlueKnightFirst = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            chkBlueSol1.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol1.Visible = False
            Red1 = True
            blue1 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol1 += 1
                Case 2
                    BlueSol1 += 2
                Case 3
                    BlueSol1 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol1 += 1
                Case 2
                    RedSol1 += 2
                Case 3
                    RedSol1 += 3

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol2.Checked = True And RedKnightSecond = False And BlueKnightSecond = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."

            chkBlueSol2.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol2.Visible = False
            Red2 = True
            blue2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol2 += 1
                Case 2
                    BlueSol2 += 2
                Case 3
                    BlueSol2 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol2 += 1
                Case 2
                    RedSol2 += 2
                Case 3
                    RedSol2 += 3

            End Select
        End If
        If chkBlueSol3.Checked = True And chkRedSol3.Checked = True And RedKnightThird = False And BlueKnightThird = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol3.Visible = False
            Red3 = True
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol3 += 1
                Case 2
                    BlueSol3 += 2
                Case 3
                    BlueSol3 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol3 += 1
                Case 2
                    RedSol3 += 2
                Case 3
                    RedSol3 += 3

            End Select

        End If
        If chkBlueSol1.Checked = True And chkRedSol3.Checked = True And RedKnightThird = False And BlueKnightFirst = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            chkBlueSol1.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol3.Visible = False
            blue1 = True
            Red3 = True
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            Select Case randomBlueHealth
                Case 1
                    BlueSol1 += 1
                Case 2
                    BlueSol1 += 2
                Case 3
                    BlueSol1 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol3 += 1
                Case 2
                    RedSol3 += 2
                Case 3
                    RedSol3 += 3

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol3.Checked = True And RedKnightThird = False And BlueKnightSecond = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            chkBlueSol2.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol3.Visible = False
            blue2 = True
            Red3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol2 += 1
                Case 2
                    BlueSol2 += 2
                Case 3
                    BlueSol2 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol3 += 1
                Case 2
                    RedSol3 += 2
                Case 3
                    RedSol3 += 3

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = False And BlueKnightSecond = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."

            chkBlueSol2.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol1.Visible = False

            Red1 = True
            blue2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol2 += 1
                Case 2
                    BlueSol2 += 2
                Case 3
                    BlueSol2 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol1 += 1
                Case 2
                    RedSol1 += 2
                Case 3
                    RedSol1 += 3

            End Select
        End If

        If chkBlueSol3.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = False And BlueKnightThird = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol1.Visible = False

            Red1 = True
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol3 += 1
                Case 2
                    BlueSol3 += 2
                Case 3
                    BlueSol3 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol1 += 1
                Case 2
                    RedSol1 += 2
                Case 3
                    RedSol1 += 3

            End Select
        End If
        If chkBlueSol3.Checked = True And chkRedSol2.Checked = True And RedKnightSecond = False And BlueKnightThird = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol2.Visible = False

            blue3 = True
            Red2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol3 += 1
                Case 2
                    BlueSol3 += 2
                Case 3
                    BlueSol3 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol2 += 1
                Case 2
                    RedSol2 += 2
                Case 3
                    RedSol2 += 3

            End Select
        End If
        If chkRedSol2.Checked = True And chkBlueSol1.Checked = True And RedKnightSecond = False And BlueKnightFirst = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."

            chkBlueSol1.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol2.Visible = False

            blue1 = True
            Red2 = True

            Select Case randomBlueHealth
                Case 1
                    BlueSol1 += 1
                Case 2
                    BlueSol1 += 2
                Case 3
                    BlueSol1 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol2 += 1
                Case 2
                    RedSol2 += 2
                Case 3
                    RedSol2 += 3

            End Select
        End If


        If chkCBoss.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Boss loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."

            chkRedSol1.Checked = False
            chkCBoss.Checked = False
            chkRedSol1.Visible = False

            Red1 = True
            Select Case randomBlueHealth
                Case 1
                    Chealth += 1
                Case 2
                    Chealth += 2
                Case 3
                    Chealth += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol1 += 1
                Case 2
                    RedSol1 += 2
                Case 3
                    RedSol1 += 3

            End Select
        End If
        If chkCBoss.Checked = True And chkRedSol2.Checked = True And RedKnightSecond = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Boss loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."

            chkRedSol2.Checked = False
            chkCBoss.Checked = False
            chkRedSol2.Visible = False

            Red2 = True
            Select Case randomBlueHealth
                Case 1
                    Chealth += 1
                Case 2
                    Chealth += 2
                Case 3
                    Chealth += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol2 += 1
                Case 2
                    RedSol2 += 2
                Case 3
                    RedSol2 += 3

            End Select
        End If
        If chkCBoss.Checked = True And chkRedSol3.Checked = True And RedKnightThird = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Boss loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."

            chkRedSol3.Checked = False
            chkCBoss.Checked = False
            chkRedSol3.Visible = False

            Red3 = True
            Select Case randomBlueHealth
                Case 1
                    Chealth += 1
                Case 2
                    Chealth += 2
                Case 3
                    Chealth += 3
            End Select
            Select Case randomRedHealth
                Case 1
                    RedSol3 += 1
                Case 2
                    RedSol3 += 2
                Case 3
                    RedSol3 += 3

            End Select


        End If

        If chkBlueSol1.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = True And BlueKnightFirst = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."
            chkBlueSol1.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol1.Visible = False

            Red1 = True
            blue1 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol1 += 1
                Case 2
                    BlueSol1 += 2
                Case 3
                    BlueSol1 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight1 += 1
                Case 2
                    RedKnight1 += 2
                Case 3
                    RedKnight1 += 3

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol2.Checked = True And RedKnightSecond = True And BlueKnightSecond = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol2.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol2.Visible = False

            Red2 = True
            blue2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol2 += 1
                Case 2
                    BlueSol2 += 2
                Case 3
                    BlueSol2 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight2 += 1
                Case 2
                    RedKnight2 += 2
                Case 3
                    RedKnight2 += 3

            End Select
        End If
        If chkBlueSol3.Checked = True And chkRedSol3.Checked = True And RedKnightThird = True And RedKnightThird = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol3.Visible = False

            Red3 = True
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol3 += 1
                Case 2
                    BlueSol3 += 2
                Case 3
                    BlueSol3 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight3 += 1
                Case 2
                    RedKnight3 += 2
                Case 3
                    RedKnight3 += 3

            End Select

        End If
        If chkBlueSol1.Checked = True And chkRedSol3.Checked = True And RedKnightThird = True And BlueKnightFirst = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            chkBlueSol1.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol3.Visible = False
            blue1 = True
            Red3 = True
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."
            Select Case randomBlueHealth
                Case 1
                    BlueSol1 += 1
                Case 2
                    BlueSol1 += 2
                Case 3
                    BlueSol1 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight3 += 1
                Case 2
                    RedKnight3 += 2
                Case 3
                    RedKnight3 += 3

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol3.Checked = True And RedKnightThird = True And BlueKnightSecond = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."
            chkBlueSol2.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol3.Visible = False

            blue2 = True
            Red3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol2 += 1
                Case 2
                    BlueSol2 += 2
                Case 3
                    BlueSol2 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight3 += 1
                Case 2
                    RedKnight3 += 2
                Case 3
                    RedKnight3 += 3

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = True And BlueKnightSecond = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol2.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol1.Visible = False
            Red1 = True
            blue2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol2 += 1
                Case 2
                    BlueSol2 += 2
                Case 3
                    BlueSol2 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight1 += 1
                Case 2
                    RedKnight1 += 2
                Case 3
                    RedKnight1 += 3

            End Select
        End If

        If chkBlueSol3.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = True And BlueKnightThird = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol1.Visible = False

            Red1 = True
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol3 += 1
                Case 2
                    BlueSol3 += 2
                Case 3
                    BlueSol3 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight1 += 1
                Case 2
                    RedKnight1 += 2
                Case 3
                    RedKnight1 += 3

            End Select
        End If
        If chkBlueSol3.Checked = True And chkRedSol2.Checked = True And RedKnightSecond = True And BlueKnightThird = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol2.Visible = False

            Red2 = True
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol3 += 1
                Case 2
                    BlueSol3 += 2
                Case 3
                    BlueSol3 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight2 += 1
                Case 2
                    RedKnight2 += 2
                Case 3
                    RedKnight2 += 3

            End Select
        End If
        If chkRedSol2.Checked = True And chkBlueSol1.Checked = True And RedKnightSecond = True And BlueKnightFirst = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol1.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol2.Visible = False
            blue1 = True
            Red2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueSol1 += 1
                Case 2
                    BlueSol1 += 2
                Case 3
                    BlueSol1 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight2 += 1
                Case 2
                    RedKnight2 += 2
                Case 3
                    RedKnight2 += 3

            End Select
        End If


        If chkCBoss.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = True Then
            randomBlueHealth = RndInt(1, 4)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkRedSol1.Checked = False
            chkCBoss.Checked = False
            chkRedSol1.Visible = False
            Red1 = True
            Select Case randomBlueHealth
                Case 1
                    Chealth += 1
                Case 2
                    Chealth += 2
                Case 3
                    Chealth += 3
            End Select
            Select Case randomRedHealth
                Case 1
                    RedKnight1 += 1
                Case 2
                    RedKnight1 += 2
                Case 3
                    RedKnight1 += 3
                Case 4
                    RedKnight1 += 4
                Case 5
                    RedKnight1 += 5
                Case 6
                    RedKnight1 += 6
            End Select
        End If
        If chkCBoss.Checked = True And chkRedSol2.Checked = True And RedKnightSecond = True Then
            randomBlueHealth = RndInt(1, 4)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkRedSol2.Checked = False
            chkCBoss.Checked = False
            chkRedSol2.Visible = False
            Red2 = True
            Select Case randomBlueHealth
                Case 1
                    Chealth += 1
                Case 2
                    Chealth += 2
                Case 3
                    Chealth += 3
                Case 4
                    Chealth += 4
                Case 5
                    Chealth += 5
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight2 += 1
                Case 2
                    RedKnight2 += 2
                Case 3
                    RedKnight2 += 3
                Case 4
                    RedKnight2 += 4
                Case 5
                    RedKnight2 += 5
                Case 6
                    RedKnight2 += 6
            End Select
        End If
        If chkCBoss.Checked = True And chkRedSol3.Checked = True And RedKnightThird = True Then
            randomBlueHealth = RndInt(1, 4)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkRedSol3.Checked = False
            chkCBoss.Checked = False
            chkRedSol3.Visible = False
            Red3 = True
            Select Case randomBlueHealth
                Case 1
                    Chealth += 1
                Case 2
                    Chealth += 2
                Case 3
                    Chealth += 3
            End Select
            Select Case randomRedHealth
                Case 1
                    RedKnight3 += 1
                Case 2
                    RedKnight3 += 2
                Case 3
                    RedKnight3 += 3
                Case 4
                    RedKnight3 += 4
                Case 5
                    RedKnight3 += 5
                Case 6
                    RedKnight3 += 6
            End Select

        End If


        If chkPBoss.Checked = True And chkBlueSol1.Checked = True And BlueKnightFirst = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Boss loses " & randomRedHealth & " heart(s)."

            chkBlueSol1.Checked = False
            chkPBoss.Checked = False
            chkBlueSol1.Visible = False

            blue1 = True
            Select Case randomBlueHealth
                Case 1
                    Phealth += 1
                Case 2
                    Phealth += 2
                Case 3
                    Phealth += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    BlueSol1 += 1
                Case 2
                    BlueSol1 += 2
                Case 3
                    BlueSol1 += 3

            End Select
        End If
        If chkPBoss.Checked = True And chkBlueSol2.Checked = True And BlueKnightSecond = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Boss loses " & randomRedHealth & " heart(s)."

            chkBlueSol2.Checked = False
            chkPBoss.Checked = False
            chkBlueSol2.Visible = False

            blue2 = True
            Select Case randomBlueHealth
                Case 1
                    Phealth += 1
                Case 2
                    Phealth += 2
                Case 3
                    Phealth += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    BlueSol2 += 1
                Case 2
                    BlueSol2 += 2
                Case 3
                    BlueSol2 += 3

            End Select
        End If
        If chkPBoss.Checked = True And chkBlueSol3.Checked = True And BlueKnightThird = False Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblBlueMessage.Text = "The Blue Soldier loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Boss loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkPBoss.Checked = False
            chkBlueSol3.Visible = False

            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    Phealth += 1
                Case 2
                    Phealth += 2
                Case 3
                    Phealth += 3
            End Select
            Select Case randomRedHealth
                Case 1
                    BlueSol3 += 1
                Case 2
                    BlueSol3 += 2
                Case 3
                    BlueSol3 += 3

            End Select


        End If



        If chkPBoss.Checked = True And chkBlueSol1.Checked = True And BlueKnightFirst = True Then
            randomBlueHealth = RndInt(1, 4)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Boss loses " & randomRedHealth & " heart(s)."

            chkBlueSol1.Checked = False
            chkPBoss.Checked = False
            chkBlueSol1.Visible = False
            blue1 = True
            Select Case randomBlueHealth
                Case 1
                    Phealth += 1
                Case 2
                    Phealth += 2
                Case 3
                    Phealth += 3
            End Select
            Select Case randomRedHealth
                Case 1
                    BlueKnight1 += 1
                Case 2
                    BlueKnight1 += 2
                Case 3
                    BlueKnight1 += 3
                Case 4
                    BlueKnight1 += 4
                Case 5
                    BlueKnight1 += 5
                Case 6
                    BlueKnight1 += 6
            End Select
        End If
        If chkPBoss.Checked = True And chkBlueSol2.Checked = True And BlueKnightSecond = True Then
            randomBlueHealth = RndInt(1, 4)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Boss loses " & randomRedHealth & " heart(s)."

            chkBlueSol2.Checked = False
            chkPBoss.Checked = False
            chkBlueSol2.Visible = False
            blue2 = True
            Select Case randomBlueHealth
                Case 1
                    Phealth += 1
                Case 2
                    Phealth += 2
                Case 3
                    Phealth += 3
                Case 4
                    Phealth += 4
                Case 5
                    Phealth += 5
            End Select

            Select Case randomRedHealth
                Case 1
                    BlueKnight2 += 1
                Case 2
                    BlueKnight2 += 2
                Case 3
                    BlueKnight2 += 3
                Case 4
                    BlueKnight2 += 4
                Case 5
                    BlueKnight2 += 5
                Case 6
                    BlueKnight2 += 6
            End Select
        End If
        If chkPBoss.Checked = True And chkBlueSol3.Checked = True And BlueKnightThird = True Then
            randomBlueHealth = RndInt(1, 4)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Boss loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkPBoss.Checked = False
            chkBlueSol3.Visible = False
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    Phealth += 1
                Case 2
                    Phealth += 2
                Case 3
                    Phealth += 3
            End Select
            Select Case randomRedHealth
                Case 1
                    BlueKnight3 += 1
                Case 2
                    BlueKnight3 += 2
                Case 3
                    BlueKnight3 += 3
                Case 4
                    BlueKnight3 += 4
                Case 5
                    BlueKnight3 += 5
                Case 6
                    BlueKnight3 += 6
            End Select

        End If


        If chkBlueSol1.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = True And BlueKnightFirst = True Then
            randomBlueHealth = RndInt(1, 5)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."
            chkBlueSol1.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol1.Visible = False
            Red1 = True
            blue1 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight1 += 1
                Case 2
                    BlueKnight1 += 2
                Case 3
                    BlueKnight1 += 3
                Case 4
                    BlueKnight1 += 4
                Case 5
                    BlueKnight1 += 5
                Case 6
                    BlueKnight1 += 6
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight1 += 1
                Case 2
                    RedKnight1 += 2
                Case 3
                    RedKnight1 += 3
                Case 4
                    RedKnight1 += 4
                Case 5
                    RedKnight1 += 5
                Case 6
                    RedKnight1 += 6

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol2.Checked = True And RedKnightSecond = True And BlueKnightSecond = True Then
            randomBlueHealth = RndInt(1, 5)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol2.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol2.Visible = False
            Red2 = True
            blue2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight2 += 1
                Case 2
                    BlueKnight2 += 2
                Case 3
                    BlueKnight2 += 3
                Case 4
                    BlueKnight2 += 4
                Case 5
                    BlueKnight2 += 5
                Case 6
                    BlueKnight2 += 6

            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight2 += 1
                Case 2
                    RedKnight2 += 2
                Case 3
                    RedKnight2 += 3
                Case 4
                    RedKnight2 += 4
                Case 5
                    RedKnight2 += 5
                Case 6
                    RedKnight2 += 6


            End Select
        End If
        If chkBlueSol3.Checked = True And chkRedSol3.Checked = True And RedKnightThird = True And BlueKnightThird = True Then
            randomBlueHealth = RndInt(1, 5)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol3.Visible = False
            Red3 = True
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight3 += 1
                Case 2
                    BlueKnight3 += 2
                Case 3
                    BlueKnight3 += 3
                Case 4
                    BlueKnight3 += 4
                Case 5
                    BlueKnight3 += 5
                Case 6
                    BlueKnight3 += 6

            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight3 += 1
                Case 2
                    RedKnight3 += 2
                Case 3
                    RedKnight3 += 3
                Case 4
                    RedKnight3 += 4
                Case 5
                    RedKnight3 += 5
                Case 6
                    RedKnight3 += 6

            End Select

        End If
        If chkBlueSol1.Checked = True And chkRedSol3.Checked = True And RedKnightThird = True And BlueKnightFirst = True Then
            randomBlueHealth = RndInt(1, 5)
            randomRedHealth = RndInt(1, 5)
            chkBlueSol1.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol3.Visible = False
            blue1 = True
            Red3 = True
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."
            Select Case randomBlueHealth
                Case 1
                    BlueKnight1 += 1
                Case 2
                    BlueKnight1 += 2
                Case 3
                    BlueKnight1 += 3
                Case 4
                    BlueKnight1 += 4
                Case 5
                    BlueKnight1 += 5
                Case 6
                    BlueKnight1 += 6
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight3 += 1
                Case 2
                    RedKnight3 += 2
                Case 3
                    RedKnight3 += 3
                Case 4
                    RedKnight3 += 4
                Case 5
                    RedKnight3 += 5
                Case 6
                    RedKnight3 += 6

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol3.Checked = True And RedKnightThird = True And BlueKnightSecond = True Then
            randomBlueHealth = RndInt(1, 5)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."
            chkBlueSol2.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol3.Visible = False
            blue2 = True
            Red3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight2 += 1
                Case 2
                    BlueKnight2 += 2
                Case 3
                    BlueKnight2 += 3
                Case 4
                    BlueKnight2 += 4
                Case 5
                    BlueKnight2 += 5
                Case 6
                    BlueKnight2 += 6
            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight3 += 1
                Case 2
                    RedKnight3 += 2
                Case 3
                    RedKnight3 += 3
                Case 4
                    RedKnight3 += 4
                Case 5
                    RedKnight3 += 5
                Case 6
                    RedKnight3 += 6

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = True And BlueKnightSecond = True Then
            randomBlueHealth = RndInt(1, 5)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol2.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol1.Visible = False

            Red1 = True
            blue2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight2 += 1
                Case 2
                    BlueKnight2 += 2
                Case 3
                    BlueKnight2 += 3
                Case 4
                    BlueKnight2 += 4
                Case 5
                    BlueKnight2 += 5
                Case 6
                    BlueKnight2 += 6

            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight1 += 1
                Case 2
                    RedKnight1 += 2
                Case 3
                    RedKnight1 += 3
                Case 4
                    RedKnight1 += 4
                Case 5
                    RedKnight1 += 5
                Case 6
                    RedKnight1 += 6


            End Select
        End If

        If chkBlueSol3.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = True And BlueKnightThird = True Then
            randomBlueHealth = RndInt(1, 5)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol1.Visible = False

            Red1 = True
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight3 += 1
                Case 2
                    BlueKnight3 += 2
                Case 3
                    BlueKnight3 += 3
                Case 4
                    BlueKnight3 += 4
                Case 5
                    BlueKnight3 += 5
                Case 6
                    BlueKnight3 += 6

            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight1 += 1
                Case 2
                    RedKnight1 += 2
                Case 3
                    RedKnight1 += 3
                Case 4
                    RedKnight1 += 4
                Case 5
                    RedKnight1 += 5
                Case 6
                    RedKnight1 += 6

            End Select
        End If
        If chkBlueSol3.Checked = True And chkRedSol2.Checked = True And RedKnightSecond = True And BlueKnightThird = True Then
            randomBlueHealth = RndInt(1, 5)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol2.Visible = False

            blue3 = True
            Red2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight3 += 1
                Case 2
                    BlueKnight3 += 2
                Case 3
                    BlueKnight3 += 3
                Case 4
                    BlueKnight3 += 4
                Case 5
                    BlueKnight3 += 5
                Case 6
                    BlueKnight3 += 6

            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight2 += 1
                Case 2
                    RedKnight2 += 2
                Case 3
                    RedKnight2 += 3
                Case 4
                    RedKnight2 += 4
                Case 5
                    RedKnight2 += 5
                Case 6
                    RedKnight2 += 6

            End Select
        End If
        If chkRedSol2.Checked = True And chkBlueSol1.Checked = True And RedKnightSecond = True And BlueKnightFirst = True Then
            randomBlueHealth = RndInt(1, 5)
            randomRedHealth = RndInt(1, 5)
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Me.lblRedMessage.Text = "The Red Knight loses " & randomRedHealth & " heart(s)."

            chkBlueSol1.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol2.Visible = False

            blue1 = True
            Red2 = True

            Select Case randomBlueHealth
                Case 1
                    BlueKnight1 += 1
                Case 2
                    BlueKnight1 += 2
                Case 3
                    BlueKnight1 += 3
                Case 4
                    BlueKnight1 += 4
                Case 5
                    BlueKnight1 += 5
                Case 6
                    BlueKnight1 += 6

            End Select

            Select Case randomRedHealth
                Case 1
                    RedKnight2 += 1
                Case 2
                    RedKnight2 += 2
                Case 3
                    RedKnight2 += 3
                Case 4
                    RedKnight2 += 4
                Case 5
                    RedKnight2 += 5
                Case 6
                    RedKnight2 += 6


            End Select
        End If


        If chkBlueSol1.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = False And BlueKnightFirst = True Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            chkBlueSol1.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol1.Visible = False

            Red1 = True
            blue1 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight1 += 1
                Case 2
                    BlueKnight1 += 2
                Case 3
                    BlueKnight1 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol1 += 1
                Case 2
                    RedSol1 += 2
                Case 3
                    RedSol1 += 3

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol2.Checked = True And RedKnightSecond = False And BlueKnightSecond = True Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."

            chkBlueSol2.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol2.Visible = False

            Red2 = True
            blue2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight2 += 1
                Case 2
                    BlueKnight2 += 2
                Case 3
                    BlueKnight2 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol2 += 1
                Case 2
                    RedSol2 += 2
                Case 3
                    RedSol2 += 3

            End Select
        End If
        If chkBlueSol3.Checked = True And chkRedSol3.Checked = True And RedKnightThird = False And RedKnightThird = True Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol3.Visible = False

            Red3 = True
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight3 += 1
                Case 2
                    BlueKnight3 += 2
                Case 3
                    BlueKnight3 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol3 += 1
                Case 2
                    RedSol3 += 2
                Case 3
                    RedSol3 += 3

            End Select

        End If
        If chkBlueSol1.Checked = True And chkRedSol3.Checked = True And RedKnightThird = False And BlueKnightFirst = True Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            chkBlueSol1.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol3.Visible = False
            blue1 = True
            Red3 = True
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            Select Case randomBlueHealth
                Case 1
                    BlueKnight1 += 1
                Case 2
                    BlueKnight1 += 2
                Case 3
                    BlueKnight1 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol3 += 1
                Case 2
                    RedSol3 += 2
                Case 3
                    RedSol3 += 3

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol3.Checked = True And RedKnightThird = False And BlueKnightSecond = True Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."
            chkBlueSol2.Checked = False
            chkRedSol3.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol3.Visible = False

            blue2 = True
            Red3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight2 += 1
                Case 2
                    BlueKnight2 += 2
                Case 3
                    BlueKnight2 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol3 += 1
                Case 2
                    RedSol3 += 2
                Case 3
                    RedSol3 += 3

            End Select
        End If
        If chkBlueSol2.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = False And BlueKnightSecond = True Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."

            chkBlueSol2.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol2.Visible = False
            chkRedSol1.Visible = False
            Red1 = True
            blue2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight2 += 1
                Case 2
                    BlueKnight2 += 2
                Case 3
                    BlueKnight2 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol1 += 1
                Case 2
                    RedSol1 += 2
                Case 3
                    RedSol1 += 3

            End Select
        End If

        If chkBlueSol3.Checked = True And chkRedSol1.Checked = True And RedKnightFirst = False And BlueKnightThird = True Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol1.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol1.Visible = False

            Red1 = True
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight3 += 1
                Case 2
                    BlueKnight3 += 2
                Case 3
                    BlueKnight3 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol1 += 1
                Case 2
                    RedSol1 += 2
                Case 3
                    RedSol1 += 3

            End Select
        End If
        If chkBlueSol3.Checked = True And chkRedSol2.Checked = True And RedKnightSecond = False And BlueKnightThird = True Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."

            chkBlueSol3.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol3.Visible = False
            chkRedSol2.Visible = False

            Red2 = True
            blue3 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight3 += 1
                Case 2
                    BlueKnight3 += 2
                Case 3
                    BlueKnight3 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol2 += 1
                Case 2
                    RedSol2 += 2
                Case 3
                    RedSol2 += 3

            End Select
        End If
        If chkRedSol2.Checked = True And chkBlueSol1.Checked = True And RedKnightSecond = False And BlueKnightFirst = True Then
            randomBlueHealth = RndInt(1, 2)
            randomRedHealth = RndInt(1, 2)
            Me.lblRedMessage.Text = "The Red Soldier loses " & randomRedHealth & " heart(s)."
            Me.lblBlueMessage.Text = "The Blue Knight loses " & randomBlueHealth & " heart(s)."

            chkBlueSol1.Checked = False
            chkRedSol2.Checked = False
            chkBlueSol1.Visible = False
            chkRedSol2.Visible = False
            blue1 = True
            Red2 = True
            Select Case randomBlueHealth
                Case 1
                    BlueKnight1 += 1
                Case 2
                    BlueKnight1 += 2
                Case 3
                    BlueKnight1 += 3
            End Select

            Select Case randomRedHealth
                Case 1
                    RedSol2 += 1
                Case 2
                    RedSol2 += 2
                Case 3
                    RedSol2 += 3

            End Select
        End If
        Select Case Phealth
            Case 1
                Me.lblPHealth.Text = "ŒŒŒŒŒŒŒŒŒ"
            Case 2
                Me.lblPHealth.Text = "ŒŒŒŒŒŒŒŒ"
            Case 3
                Me.lblPHealth.Text = "ŒŒŒŒŒŒŒ"
            Case 4
                Me.lblPHealth.Text = "ŒŒŒŒŒŒ"
            Case 5
                Me.lblPHealth.Text = "ŒŒŒŒŒ"
            Case 6
                Me.lblPHealth.Text = "ŒŒŒŒ"
            Case 7
                Me.lblPHealth.Text = "ŒŒŒ"
            Case 8
                Me.lblPHealth.Text = "ŒŒ"
            Case 9
                Me.lblPHealth.Text = "Œ"
            Case 10
                Me.lblPHealth.Text = ""
            Case 11
                Me.lblPHealth.Text = ""
            Case 12
                Me.lblPHealth.Text = ""
            Case 13
                Me.lblPHealth.Text = ""
        End Select



        Select Case Chealth
            Case 1
                Me.lblCHealth.Text = "ŒŒŒŒŒŒŒŒŒ"
            Case 2
                Me.lblCHealth.Text = "ŒŒŒŒŒŒŒŒ"
            Case 3
                Me.lblCHealth.Text = "ŒŒŒŒŒŒŒ"
            Case 4
                Me.lblCHealth.Text = "ŒŒŒŒŒŒ"
            Case 5
                Me.lblCHealth.Text = "ŒŒŒŒŒ"
            Case 6
                Me.lblCHealth.Text = "ŒŒŒŒ"
            Case 7
                Me.lblCHealth.Text = "ŒŒŒ"
            Case 8
                Me.lblCHealth.Text = "ŒŒ"
            Case 9
                Me.lblCHealth.Text = "Œ"
            Case 10
                Me.lblCHealth.Text = ""
            Case 11
                Me.lblCHealth.Text = ""
            Case 12
                Me.lblCHealth.Text = ""
            Case 13
                Me.lblCHealth.Text = ""
        End Select


        Select Case BlueSol1
            Case 1
                Me.lblBlueSol1.Text = "ŒŒ"
            Case 2
                Me.lblBlueSol1.Text = "Œ"
            Case 3
                Me.lblBlueSol1.Text = ""
            Case 4
                Me.lblBlueSol1.Text = ""
            Case 5
                Me.lblBlueSol1.Text = ""
        End Select

        Select Case RedSol1
            Case 1
                Me.lblRedSol1.Text = "ŒŒ"
            Case 2
                Me.lblRedSol1.Text = "Œ"
            Case 3
                Me.lblRedSol1.Text = ""
            Case 4
                Me.lblRedSol1.Text = ""
            Case 5
                Me.lblRedSol1.Text = ""
        End Select


        Select Case BlueSol2
            Case 1
                Me.lblBlueSol2.Text = "ŒŒ"
            Case 2
                Me.lblBlueSol2.Text = "Œ"
            Case 3
                Me.lblBlueSol2.Text = ""
            Case 4
                Me.lblBlueSol2.Text = ""
            Case 5
                Me.lblBlueSol2.Text = ""
        End Select

        Select Case RedSol2
            Case 1
                Me.lblRedSol2.Text = "ŒŒ"
            Case 2
                Me.lblRedSol2.Text = "Œ"
            Case 3
                Me.lblRedSol2.Text = ""
            Case 4
                Me.lblRedSol2.Text = ""
            Case 5
                Me.lblRedSol2.Text = ""
        End Select


        Select Case BlueSol3
            Case 1
                Me.lblBlueSol3.Text = "ŒŒ"
            Case 2
                Me.lblBlueSol3.Text = "Œ"
            Case 3
                Me.lblBlueSol3.Text = ""
            Case 4
                Me.lblBlueSol3.Text = ""
            Case 5
                Me.lblBlueSol3.Text = ""
        End Select

        Select Case RedSol3
            Case 1
                Me.lblRedSol3.Text = "ŒŒ"
            Case 2
                Me.lblRedSol3.Text = "Œ"
            Case 3
                Me.lblRedSol3.Text = ""
            Case 4
                Me.lblRedSol3.Text = ""
            Case 5
                Me.lblRedSol3.Text = ""
        End Select

        Select Case RedKnight3
            Case 1
                Me.lblRedSol3.Text = "ŒŒŒŒŒ"
            Case 2
                Me.lblRedSol3.Text = "ŒŒŒŒ"
            Case 3
                Me.lblRedSol3.Text = "ŒŒŒ"
            Case 4
                Me.lblRedSol3.Text = "ŒŒ"
            Case 5
                Me.lblRedSol3.Text = "Œ"
            Case 6
                Me.lblRedSol3.Text = ""
            Case 7
                Me.lblRedSol3.Text = ""
            Case 8
                Me.lblRedSol3.Text = ""
            Case 9
                Me.lblRedSol3.Text = ""
        End Select

        Select Case RedKnight1
            Case 1
                Me.lblRedSol1.Text = "ŒŒŒŒŒ"
            Case 2
                Me.lblRedSol1.Text = "ŒŒŒŒ"
            Case 3
                Me.lblRedSol1.Text = "ŒŒŒ"
            Case 4
                Me.lblRedSol1.Text = "ŒŒ"
            Case 5
                Me.lblRedSol1.Text = "Œ"
            Case 6
                Me.lblRedSol1.Text = ""
            Case 7
                Me.lblRedSol1.Text = ""
            Case 8
                Me.lblRedSol1.Text = ""
            Case 9
                Me.lblRedSol1.Text = ""
        End Select
        Select Case RedKnight2
            Case 1
                Me.lblRedSol2.Text = "ŒŒŒŒŒ"
            Case 2
                Me.lblRedSol2.Text = "ŒŒŒŒ"
            Case 3
                Me.lblRedSol2.Text = "ŒŒŒ"
            Case 4
                Me.lblRedSol2.Text = "ŒŒ"
            Case 5
                Me.lblRedSol2.Text = "Œ"
            Case 6
                Me.lblRedSol2.Text = ""
            Case 7
                Me.lblRedSol2.Text = ""
            Case 8
                Me.lblRedSol2.Text = ""
            Case 9
                Me.lblRedSol2.Text = ""
        End Select

        Select Case BlueKnight3
            Case 1
                Me.lblBlueSol3.Text = "ŒŒŒŒŒ"
            Case 2
                Me.lblBlueSol3.Text = "ŒŒŒŒ"
            Case 3
                Me.lblBlueSol3.Text = "ŒŒŒ"
            Case 4
                Me.lblBlueSol3.Text = "ŒŒ"
            Case 5
                Me.lblBlueSol3.Text = "Œ"
            Case 6
                Me.lblBlueSol3.Text = ""
            Case 7
                Me.lblBlueSol3.Text = ""
            Case 8
                Me.lblBlueSol3.Text = ""
            Case 9
                Me.lblBlueSol3.Text = ""
        End Select

        Select Case BlueKnight1
            Case 1
                Me.lblBlueSol1.Text = "ŒŒŒŒŒ"
            Case 2
                Me.lblBlueSol1.Text = "ŒŒŒŒ"
            Case 3
                Me.lblBlueSol1.Text = "ŒŒŒ"
            Case 4
                Me.lblBlueSol1.Text = "ŒŒ"
            Case 5
                Me.lblBlueSol1.Text = "Œ"
            Case 6
                Me.lblBlueSol1.Text = ""
            Case 7
                Me.lblBlueSol1.Text = ""
            Case 8
                Me.lblBlueSol1.Text = ""
            Case 9
                Me.lblBlueSol1.Text = ""
        End Select
        Select Case BlueKnight2
            Case 1
                Me.lblBlueSol2.Text = "ŒŒŒŒŒ"
            Case 2
                Me.lblBlueSol2.Text = "ŒŒŒŒ"
            Case 3
                Me.lblBlueSol2.Text = "ŒŒŒ"
            Case 4
                Me.lblBlueSol2.Text = "ŒŒ"
            Case 5
                Me.lblBlueSol2.Text = "Œ"
            Case 6
                Me.lblBlueSol2.Text = ""
            Case 7
                Me.lblBlueSol2.Text = ""
            Case 8
                Me.lblBlueSol2.Text = ""
            Case 9
                Me.lblBlueSol2.Text = ""
        End Select
        If lblRedSol1.Text = "" Then
            Me.picRedSol1.Visible = False
            Me.lblRedSol1.Visible = False
            Me.chkRedSol1.Visible = False
            Red1 = False
            RedSol1 = 0
            RedKnight1 = 0

        End If

        If lblRedSol2.Text = "" Then
            Me.picRedSol2.Visible = False
            Me.lblRedSol2.Visible = False
            Me.chkRedSol2.Visible = False
            Red2 = False
            RedSol2 = 0
            RedKnight2 = 0

        End If

        If lblRedSol3.Text = "" Then
            Me.picRedSol3.Visible = False
            Me.lblRedSol3.Visible = False
            Me.chkRedSol3.Visible = False
            Red3 = False
            RedSol3 = 0
            RedKnight3 = 0

        End If

        If lblBlueSol1.Text = "" Then
            Me.picBlueSol1.Visible = False
            Me.lblBlueSol1.Visible = False
            Me.chkBlueSol1.Visible = False
            blue1 = False
            BlueSol1 = 0

        End If

        If lblBlueSol2.Text = "" Then
            Me.picBlueSol2.Visible = False
            Me.lblBlueSol2.Visible = False
            Me.chkBlueSol2.Visible = False
            blue2 = False
            BlueSol2 = 0
        End If

        If lblBlueSol3.Text = "" Then
            Me.picBlueSol3.Visible = False
            Me.lblBlueSol3.Visible = False
            Me.chkBlueSol3.Visible = False
            blue3 = False
            BlueSol3 = 0
        End If

        If Me.picBlueSol1.Visible = False And Me.picBlueSol2.Visible = False And Me.picBlueSol3.Visible = False Then
            Me.chkCBoss.Visible = True
        End If

        If Me.picRedSol1.Visible = False And Me.picRedSol2.Visible = False And Me.picRedSol3.Visible = False Then
            Me.chkPBoss.Visible = True
        End If



        If lblPHealth.Text = "" Then
            Select Case MsgBox("Player One has lost. Do you want to play again?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    Application.Restart()
                Case MsgBoxResult.No
                    Application.Exit()
            End Select
        End If
        If lblCHealth.Text = "" Then
            Select Case MsgBox("Player Two has lost. Do you want to play again?", MsgBoxStyle.YesNo)
                Case MsgBoxResult.Yes
                    Application.Restart()
                Case MsgBoxResult.No
                    Application.Exit()
            End Select
        End If
    End Sub





    Function RndInt(ByVal lowNumber As Integer, ByVal highNumber As Integer) As Integer
        Return Int(highNumber - lowNumber + 1) * Rnd() + lowNumber
    End Function

    Private Sub btnSoldier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoldier.Click
        Static counter As Integer = 0

        If picRedSol1.Visible = False Then
            counter = 0
        ElseIf picRedSol2.Visible = False Then
            counter = 1
        ElseIf picRedSol3.Visible = False Then

            counter = 2
        End If

        If counter = 0 Then
            Me.picRedSol1.Image = My.Resources.RedSoldier
            Me.lblRedSol1.Text = "ŒŒŒ"
            Me.chkRedSol1.Visible = True
            Me.lblRedSol1.Visible = True
            Me.picRedSol1.Visible = True
            Redmoney -= 100
            Me.lblFirstMoney.Text = "$" & Redmoney
            Red1 = True
            RedKnightFirst = False
        End If
        counter += 1

        If counter = 2 Then
            Me.picRedSol2.Image = My.Resources.RedSoldier
            Me.lblRedSol2.Text = "ŒŒŒ"
            Me.chkRedSol2.Visible = True
            Me.lblRedSol2.Visible = True
            Me.picRedSol2.Visible = True
            Redmoney -= 100
            Me.lblFirstMoney.Text = "$" & Redmoney
            Red2 = True
            RedKnightSecond = False
        End If
        If counter = 3 Then
            Me.picRedSol3.Image = My.Resources.RedSoldier
            Me.lblRedSol3.Text = "ŒŒŒ"
            Me.chkRedSol3.Visible = True
            Me.picRedSol3.Visible = True
            Me.lblRedSol3.Visible = True
            Redmoney -= 100
            Me.lblFirstMoney.Text = "$" & Redmoney
            counter = 0
            Red3 = True
            RedKnightThird = False
        End If


        If lblFirstMoney.Text = "$0" Then
            Me.btnSoldier.Enabled = False
            Me.btnRedKnight.Enabled = False
        End If
        If Redmoney < 400 Then
            Me.btnRedKnight.Enabled = False
        End If
    End Sub

    Private Sub lblEndTurn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEndTurn.Click
        Static COUNTeR As Integer = 0
        Redmoney = 100 + (COUNTeR * 100)
        Bluemoney = 100 + (COUNTeR * 100)
        COUNTeR += 1


        If Redmoney >= 400 Then
            Me.btnRedKnight.Enabled = True
        End If
        Select Case COUNTeR
            Case 1

                Me.btnSoldier.Enabled = False
                Me.btnBlueSoldier.Enabled = True
                Me.btnRedKnight.Enabled = False
                If Bluemoney >= 400 Then
                    Me.Button2.Enabled = True
                End If
                Me.lblFirstMoney.Text = "$" & Redmoney
                Me.lblSecondMoney.Text = "$" & Bluemoney
                If Red1 = True Then
                    chkRedSol1.Visible = True
                End If
                If Red2 = True Then
                    chkRedSol2.Visible = True
                End If
                If Red3 = True Then
                    chkRedSol3.Visible = True
                End If
                If blue1 = True Then
                    chkBlueSol1.Visible = True
                End If
                If blue2 = True Then
                    chkBlueSol2.Visible = True
                End If
                If blue3 = True Then
                    chkBlueSol3.Visible = True
                End If
            Case 2

                Me.btnSoldier.Enabled = True
                Me.btnBlueSoldier.Enabled = False
                If Redmoney >= 400 Then
                    Me.btnRedKnight.Enabled = True
                End If
                Me.Button2.Enabled = False
                Me.lblFirstMoney.Text = "$" & Redmoney
                Me.lblSecondMoney.Text = "$" & Bluemoney
                If Red1 = True Then
                    chkRedSol1.Visible = True
                End If
                If Red2 = True Then
                    chkRedSol2.Visible = True
                End If
                If Red3 = True Then
                    chkRedSol3.Visible = True
                End If
                If blue1 = True Then
                    chkBlueSol1.Visible = True
                End If
                If blue2 = True Then
                    chkBlueSol2.Visible = True
                End If
                If blue3 = True Then
                    chkBlueSol3.Visible = True
                End If
            Case 3

                Me.btnSoldier.Enabled = False
                Me.btnBlueSoldier.Enabled = True
                Me.btnRedKnight.Enabled = False
                If Bluemoney >= 400 Then
                    Me.Button2.Enabled = True
                End If
                Me.lblFirstMoney.Text = "$" & Redmoney
                Me.lblSecondMoney.Text = "$" & Bluemoney
                If Red1 = True Then
                    chkRedSol1.Visible = True
                End If
                If Red2 = True Then
                    chkRedSol2.Visible = True
                End If
                If Red3 = True Then
                    chkRedSol3.Visible = True
                End If
                If blue1 = True Then
                    chkBlueSol1.Visible = True
                End If
                If blue2 = True Then
                    chkBlueSol2.Visible = True
                End If
                If blue3 = True Then
                    chkBlueSol3.Visible = True
                End If
            Case 4

                Me.btnSoldier.Enabled = True
                Me.btnBlueSoldier.Enabled = False
                If Redmoney >= 400 Then
                    Me.btnRedKnight.Enabled = True
                End If
                Me.Button2.Enabled = False
                Me.lblFirstMoney.Text = "$" & Redmoney
                Me.lblSecondMoney.Text = "$" & Bluemoney
                If Red1 = True Then
                    chkRedSol1.Visible = True
                End If
                If Red2 = True Then
                    chkRedSol2.Visible = True
                End If
                If Red3 = True Then
                    chkRedSol3.Visible = True
                End If
                If blue1 = True Then
                    chkBlueSol1.Visible = True
                End If
                If blue2 = True Then
                    chkBlueSol2.Visible = True
                End If
                If blue3 = True Then
                    chkBlueSol3.Visible = True
                End If
            Case 5

                Me.btnSoldier.Enabled = False
                Me.btnBlueSoldier.Enabled = True
                Me.btnRedKnight.Enabled = False
                If Bluemoney >= 400 Then
                    Me.Button2.Enabled = True
                End If
                Me.lblFirstMoney.Text = "$" & Redmoney
                Me.lblSecondMoney.Text = "$" & Bluemoney
                If Red1 = True Then
                    chkRedSol1.Visible = True
                End If
                If Red2 = True Then
                    chkRedSol2.Visible = True
                End If
                If Red3 = True Then
                    chkRedSol3.Visible = True
                End If
                If blue1 = True Then
                    chkBlueSol1.Visible = True
                End If
                If blue2 = True Then
                    chkBlueSol2.Visible = True
                End If
                If blue3 = True Then
                    chkBlueSol3.Visible = True
                End If
            Case 6

                Me.btnSoldier.Enabled = True
                Me.btnBlueSoldier.Enabled = False
                If Redmoney >= 400 Then
                    Me.btnRedKnight.Enabled = True
                End If
                Me.Button2.Enabled = False
                Me.lblFirstMoney.Text = "$" & Redmoney
                Me.lblSecondMoney.Text = "$" & Bluemoney
                If Red1 = True Then
                    chkRedSol1.Visible = True
                End If
                If Red2 = True Then
                    chkRedSol2.Visible = True
                End If
                If Red3 = True Then
                    chkRedSol3.Visible = True
                End If
                If blue1 = True Then
                    chkBlueSol1.Visible = True
                End If
                If blue2 = True Then
                    chkBlueSol2.Visible = True
                End If
                If blue3 = True Then
                    chkBlueSol3.Visible = True
                End If
            Case 7

                Me.btnSoldier.Enabled = False
                Me.btnBlueSoldier.Enabled = True
                Me.btnRedKnight.Enabled = False
                If Bluemoney >= 400 Then
                    Me.Button2.Enabled = True
                End If
                Me.lblFirstMoney.Text = "$" & Redmoney
                Me.lblSecondMoney.Text = "$" & Bluemoney
                If Red1 = True Then
                    chkRedSol1.Visible = True
                End If
                If Red2 = True Then
                    chkRedSol2.Visible = True
                End If
                If Red3 = True Then
                    chkRedSol3.Visible = True
                End If
                If blue1 = True Then
                    chkBlueSol1.Visible = True
                End If
                If blue2 = True Then
                    chkBlueSol2.Visible = True
                End If
                If blue3 = True Then
                    chkBlueSol3.Visible = True
                End If
            Case 8

                Me.btnSoldier.Enabled = True
                Me.btnBlueSoldier.Enabled = False
                If Redmoney >= 400 Then
                    Me.btnRedKnight.Enabled = True
                End If
                Me.Button2.Enabled = False
                Me.lblFirstMoney.Text = "$" & Redmoney
                Me.lblSecondMoney.Text = "$" & Bluemoney
                If Red1 = True Then
                    chkRedSol1.Visible = True
                End If
                If Red2 = True Then
                    chkRedSol2.Visible = True
                End If
                If Red3 = True Then
                    chkRedSol3.Visible = True
                End If
                If blue1 = True Then
                    chkBlueSol1.Visible = True
                End If
                If blue2 = True Then
                    chkBlueSol2.Visible = True
                End If
                If blue3 = True Then
                    chkBlueSol3.Visible = True
                End If
            Case 9

                Me.btnSoldier.Enabled = False
                Me.btnBlueSoldier.Enabled = True
                Me.btnRedKnight.Enabled = False
                If Bluemoney >= 400 Then
                    Me.Button2.Enabled = True
                End If
                Me.lblFirstMoney.Text = "$" & Redmoney
                Me.lblSecondMoney.Text = "$" & Bluemoney
                If Red1 = True Then
                    chkRedSol1.Visible = True
                End If
                If Red2 = True Then
                    chkRedSol2.Visible = True
                End If
                If Red3 = True Then
                    chkRedSol3.Visible = True
                End If
                If blue1 = True Then
                    chkBlueSol1.Visible = True
                End If
                If blue2 = True Then
                    chkBlueSol2.Visible = True
                End If
                If blue3 = True Then
                    chkBlueSol3.Visible = True
                End If
            Case 10

                Me.btnSoldier.Enabled = True
                Me.btnBlueSoldier.Enabled = False
                If Redmoney >= 400 Then
                    Me.btnRedKnight.Enabled = True
                End If
                Me.Button2.Enabled = False
                Me.lblFirstMoney.Text = "$" & Redmoney
                Me.lblSecondMoney.Text = "$" & Bluemoney
                If Red1 = True Then
                    chkRedSol1.Visible = True
                End If
                If Red2 = True Then
                    chkRedSol2.Visible = True
                End If
                If Red3 = True Then
                    chkRedSol3.Visible = True
                End If
                If blue1 = True Then
                    chkBlueSol1.Visible = True
                End If
                If blue2 = True Then
                    chkBlueSol2.Visible = True
                End If
                If blue3 = True Then
                    chkBlueSol3.Visible = True
                End If
                COUNTeR = 0
        End Select
    End Sub

    Private Sub btnBlueSoldier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlueSoldier.Click
        Static counter As Integer = 0

        If picBlueSol1.Visible = False Then
            counter = 0
        ElseIf picBlueSol2.Visible = False Then
            counter = 1
        ElseIf picBlueSol3.Visible = False Then

            counter = 2
        End If

        If counter = 0 Then
            Me.picBlueSol1.Image = My.Resources.BlueSoldier
            Me.lblBlueSol1.Text = "ŒŒŒ"
            Me.chkBlueSol1.Visible = True
            Me.lblBlueSol1.Visible = True
            Me.picBlueSol1.Visible = True
            Bluemoney -= 100
            Me.lblSecondMoney.Text = "$" & Bluemoney
            blue1 = True
            BlueKnightFirst = False
        End If
        counter += 1

        If counter = 2 Then
            Me.picBlueSol2.Image = My.Resources.BlueSoldier
            Me.lblBlueSol2.Text = "ŒŒŒ"
            Me.chkBlueSol2.Visible = True
            Me.lblBlueSol2.Visible = True
            Me.picBlueSol2.Visible = True
            Bluemoney -= 100
            Me.lblSecondMoney.Text = "$" & Bluemoney
            blue2 = True
            BlueKnightSecond = False
        End If
        If counter = 3 Then
            Me.picBlueSol3.Image = My.Resources.BlueSoldier
            Me.lblBlueSol3.Text = "ŒŒŒ"
            Me.chkBlueSol3.Visible = True
            Me.picBlueSol3.Visible = True
            Me.lblBlueSol3.Visible = True
            Bluemoney -= 100
            Me.lblSecondMoney.Text = "$" & Bluemoney
            counter = 0
            blue3 = True
            BlueKnightThird = False
        End If


        If lblSecondMoney.Text = "$0" Then
            Me.btnBlueSoldier.Enabled = False
            Me.Button2.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRedKnight.Click
        Static counter As Integer = 0

        If picRedSol1.Visible = False Then
            counter = 0
        ElseIf picRedSol2.Visible = False Then
            counter = 1
        ElseIf picRedSol3.Visible = False Then

            counter = 2
        End If

        If counter = 0 Then
            Me.picRedSol1.Image = My.Resources.RedKnight
            Me.lblRedSol1.Text = "ŒŒŒŒŒŒ"
            Me.chkRedSol1.Visible = True
            Me.lblRedSol1.Visible = True
            Me.picRedSol1.Visible = True
            RedKnightFirst = True
            Redmoney -= 400
            Me.lblFirstMoney.Text = "$" & Redmoney
        End If
        counter += 1

        If counter = 2 Then
            Me.picRedSol2.Image = My.Resources.RedKnight
            Me.lblRedSol2.Text = "ŒŒŒŒŒŒ"
            Me.chkRedSol2.Visible = True
            Me.lblRedSol2.Visible = True
            Me.picRedSol2.Visible = True
            RedKnightSecond = True
            Redmoney -= 400
            Me.lblFirstMoney.Text = "$" & Redmoney
        End If
        If counter = 3 Then
            Me.picRedSol3.Image = My.Resources.RedKnight
            Me.lblRedSol3.Text = "ŒŒŒŒŒŒ"
            Me.chkRedSol3.Visible = True
            Me.picRedSol3.Visible = True
            Me.lblRedSol3.Visible = True
            RedKnightThird = True
            Redmoney -= 400
            Me.lblFirstMoney.Text = "$" & Redmoney
            counter = 0
        End If


        If lblFirstMoney.Text = "$0" Then
            Me.btnSoldier.Enabled = False
            Me.btnRedKnight.Enabled = False
        End If
        If Redmoney < 400 Then
            Me.btnRedKnight.Enabled = False
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Static counter As Integer = 0

        If picBlueSol1.Visible = False Then
            counter = 0
        ElseIf picBlueSol2.Visible = False Then
            counter = 1
        ElseIf picBlueSol3.Visible = False Then

            counter = 2
        End If

        If counter = 0 Then
            Me.picBlueSol1.Image = My.Resources.BlueKnight
            Me.lblBlueSol1.Text = "ŒŒŒŒŒŒ"
            Me.chkBlueSol1.Visible = True
            Me.lblBlueSol1.Visible = True
            Me.picBlueSol1.Visible = True
            BlueKnightFirst = True
            Bluemoney -= 400
            Me.lblSecondMoney.Text = "$" & Bluemoney
        End If
        counter += 1

        If counter = 2 Then
            Me.picBlueSol2.Image = My.Resources.BlueKnight
            Me.lblBlueSol2.Text = "ŒŒŒŒŒŒ"
            Me.chkBlueSol2.Visible = True
            Me.lblBlueSol2.Visible = True
            Me.picBlueSol2.Visible = True
            BlueKnightSecond = True
            Bluemoney -= 400
            Me.lblSecondMoney.Text = "$" & Bluemoney
        End If
        If counter = 3 Then
            Me.picBlueSol3.Image = My.Resources.BlueKnight
            Me.lblBlueSol3.Text = "ŒŒŒŒŒŒ"
            Me.chkBlueSol3.Visible = True
            Me.picBlueSol3.Visible = True
            Me.lblBlueSol3.Visible = True
            BlueKnightThird = True
            Bluemoney -= 400
            Me.lblSecondMoney.Text = "$" & Bluemoney
            counter = 0
        End If


        If lblSecondMoney.Text = "$0" Then
            Me.Button2.Enabled = False
            Me.btnBlueSoldier.Enabled = False
        End If
        If Bluemoney < 400 Then
            Me.Button2.Enabled = False
        End If
    End Sub


End Class