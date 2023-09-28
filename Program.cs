﻿// See https://aka.ms/new-console-template for more information
using Calendar.Entities;

Console.WriteLine("Calendar App");

Meeting meeting1 = new()
{
    Title = "YetGen Jump & Akbank Backend Planlama Toplantısı",
    Details = new List<string>()
    {
        "Katılımcıların alım süreçleri konuşulacak",
        "Akbank'tan gelen mail konuşulacak",
        "Bütçe planlaması konuşulacak"
    },
    StartTime = new DateTime(2023, 09, 18, 20, 00, 00),
    FinishTime = new DateTime(2023, 09, 18, 21, 00, 00),
    Guests = new()
    {
        "Şeyma@deneme.com",
        "Hakan@deneme.com",
        "Ayşe@deneme.com"
    },
};

ToDo todo1 = new()
{
    Title = "Katılımcı geri bildirimlerini teslim et!",
    Details = new List<string>()
    {
        "Değerlendirme sonuçlarının gözden geçirilmesi",
        "Görselleştirmelerin yapılması"
    },
    StartTime = new DateTime(2023, 09, 19, 19, 00, 00),
    FinishTime = new DateTime(2023, 09, 19, 21, 00, 00),
    Importance = "High Priority"
};

meeting1.GetNotification();
todo1.GetNotification();