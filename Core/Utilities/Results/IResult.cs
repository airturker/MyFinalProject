using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } //yapmaya çalıştığın iş başarılı mı
        string Message { get; } //o iş için mesaj ver kullanıcıya
    }
}
