using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using PostComment;

namespace GrpcGreeterClient
{
    interface InterfacePost
    {
        bool AddPost(Post post);
        Post UpdatePost(Post post);
        int DeletePost(int id);
        Post GetPostById(int id);
        List<Post> GetPosts();
    }
    interface InterfaceComment
    {
        bool AddComment(Comment comment);
        Comment UpdateComment(Comment newComment);
        Comment GetCommentById(int id);
    }
    interface IPostComment : InterfacePost, InterfaceComment
    {
    }

}
