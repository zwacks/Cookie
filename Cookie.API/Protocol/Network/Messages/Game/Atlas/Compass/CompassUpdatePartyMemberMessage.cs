//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Atlas.Compass
{
    using Cookie.API.Protocol.Network.Types.Game.Context;
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.Utils.IO;
    
    
    public class CompassUpdatePartyMemberMessage : CompassUpdateMessage
    {
        
        public new const uint ProtocolId = 5589;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ulong m_memberId;
        
        public virtual ulong MemberId
        {
            get
            {
                return m_memberId;
            }
            set
            {
                m_memberId = value;
            }
        }
        
        private bool m_active;
        
        public virtual bool Active
        {
            get
            {
                return m_active;
            }
            set
            {
                m_active = value;
            }
        }
        
        public CompassUpdatePartyMemberMessage(ulong memberId, bool active)
        {
            m_memberId = memberId;
            m_active = active;
        }
        
        public CompassUpdatePartyMemberMessage()
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhLong(m_memberId);
            writer.WriteBoolean(m_active);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
            m_memberId = reader.ReadVarUhLong();
            m_active = reader.ReadBoolean();
        }
    }
}
