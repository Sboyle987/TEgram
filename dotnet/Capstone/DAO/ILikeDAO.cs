﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public interface ILikeDAO
    {
       void LikePhoto(int userId, int photoId);

        void UnlikePhoto(int userId, int photoId);

       bool GetLikeState(int userId, int photoId);
    }
}
