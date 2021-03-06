//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Types.Updater
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class ContentPart : NetworkType
    {
        
        public const short ProtocolId = 350;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private string m_ObjectId;
        
        public virtual string ObjectId
        {
            get
            {
                return m_ObjectId;
            }
            set
            {
                m_ObjectId = value;
            }
        }
        
        private byte m_state;
        
        public virtual byte State
        {
            get
            {
                return m_state;
            }
            set
            {
                m_state = value;
            }
        }
        
        public ContentPart(string objectId, byte state)
        {
            m_ObjectId = objectId;
            m_state = state;
        }
        
        public ContentPart()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUTF(m_ObjectId);
            writer.WriteByte(m_state);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_ObjectId = reader.ReadUTF();
            m_state = reader.ReadByte();
        }
    }
}
