//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Context.Roleplay.Quest
{
    using Cookie.API.Protocol.Network.Types.Game.Context.Roleplay.Quest;
    
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class QuestStepInfoMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5625;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private QuestActiveInformations m_infos;
        
        public virtual QuestActiveInformations Infos
        {
            get
            {
                return m_infos;
            }
            set
            {
                m_infos = value;
            }
        }
        
        public QuestStepInfoMessage(QuestActiveInformations infos)
        {
            m_infos = infos;
        }
        
        public QuestStepInfoMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteUShort(((ushort)(m_infos.TypeID)));
            m_infos.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            m_infos = ProtocolTypeManager.GetInstance<QuestActiveInformations>((short)reader.ReadUShort());
            m_infos.Deserialize(reader);
        }
    }
}
