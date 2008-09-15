/*
 * Form1.vb
 * This file is part of RoadworksModel
 *
 * Copyright (C) 2008 - Simon Walker
 *
 * RoadworksModel is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; either version 2 of the License, or
 * (at your option) any later version.
 *
 * RoadworksModel is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with RoadworksModel; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin St, Fifth Floor, 
 * Boston, MA  02110-1301  USA
 */
 
 

Public Class Form1
    Private Sub LFTTMR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LFTTMR.Tick
        Dim rndl As New System.Random()
        Dim randleft As New Integer
        randleft = rndl.Next(1, 7)
        Label17.Text = randleft
        If randleft = CarBox.Value Then
            CarsLeft.Value = CarsLeft.Value + 1
            If CarsLeft.Value = CarsLeft.Maximum Then
                LFTTMR.Enabled = False
                RGTTMR.Enabled = False
                MsgBox("Error - Queue too big!", MsgBoxStyle.Information, "Error")
            End If
        End If
        time.Text = time.Text + 1


        If timetype.Text = "rr(g)" Then
            LeftRed.Visible = True
            RightRed.Visible = True
            LeftGreen.Visible = False
            RightGreen.Visible = False
            CarsLeft.ForeColor = Color.Red
            CarsRight.ForeColor = Color.Red

            If time.Text = ClearTime.Value Then
                timetype.Text = "gr"
                time.Text = 0
            End If
        End If


        If timetype.Text = "gr" Then
            LeftRed.Visible = False
            RightRed.Visible = True
            LeftGreen.Visible = True
            RightGreen.Visible = False
            CarsLeft.ForeColor = Color.Green
            CarsRight.ForeColor = Color.Red

            If time.Text = FrstCar.Value Then
                If CarsLeft.Value = 0 Then
                    CarsLeft.Value = 0
                Else
                    CarsLeft.Value = CarsLeft.Value - 1
                End If
            End If
            If time.Text > FrstCar.Value Then
                If CarsLeft.Value = 0 Then
                    CarsLeft.Value = 0
                Else
                    CarsLeft.Value = CarsLeft.Value - 1
                End If
            End If
            If time.Text = RunTime.Value Then
                timetype.Text = "r(g)r"
                time.Text = 0
            End If
        End If

        If timetype.Text = "r(g)r" Then
            LeftRed.Visible = True
            RightRed.Visible = True
            LeftGreen.Visible = False
            RightGreen.Visible = False
            CarsLeft.ForeColor = Color.Red
            CarsRight.ForeColor = Color.Red

            If time.Text = ClearTime.Value Then
                timetype.Text = "rg"
                time.Text = 0
            End If
        End If


        If timetype.Text = "rg" Then
            LeftRed.Visible = True
            RightRed.Visible = False
            LeftGreen.Visible = False
            RightGreen.Visible = True
            CarsLeft.ForeColor = Color.Red
            CarsRight.ForeColor = Color.Green

            If time.Text = FrstCar.Value Then
                If CarsRight.Value = 0 Then
                    CarsRight.Value = 0
                Else
                    CarsRight.Value = CarsRight.Value - 1
                End If
            End If
            If time.Text > FrstCar.Value Then
                If CarsRight.Value = 0 Then
                    CarsRight.Value = 0
                Else
                    CarsRight.Value = CarsRight.Value - 1
                End If
            End If

            If time.Text = RunTime.Value Then
                timetype.Text = "rr(g)"
                time.Text = 0
            End If
        End If


    End Sub
    Private Sub RGTTMR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RGTTMR.Tick
        Dim rndr As New System.Random()
        Dim randright As New Integer
        randright = rndr.Next(1, 7)
        Label24.Text = randright
        If randright = CarBox.Value Then
            CarsRight.Value = CarsRight.Value + 1
            If CarsRight.Value = CarsRight.Maximum Then
                LFTTMR.Enabled = False
                RGTTMR.Enabled = False
                MsgBox("Error - Queue too big!", MsgBoxStyle.Information, "Error")
            End If
        End If
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarsRight.Value = 0
        CarsLeft.Value = 0
    End Sub
    Private Sub RunRun_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunRun.Click
        LFTTMR.Enabled = True
        RGTTMR.Enabled = True
    End Sub
    Private Sub RunStp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunStp.Click
        LFTTMR.Enabled = False
        RGTTMR.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CarsRight.Value = 0
        CarsLeft.Value = 0
        time.Text = 0
        timetype.Text = "rr(g)"
    End Sub

End Class
