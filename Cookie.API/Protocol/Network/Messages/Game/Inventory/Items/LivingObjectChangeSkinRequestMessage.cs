//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.API.Protocol.Network.Messages.Game.Inventory.Items
{
    using System.Collections.Generic;
    using Cookie.API.Protocol.Network.Messages;
    using Cookie.API.Protocol.Network.Types;
    using Cookie.API.IO;
    
    
    public class LivingObjectChangeSkinRequestMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5725;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private uint m_livingUID;
        
        public virtual uint LivingUID
        {
            get
            {
                return m_livingUID;
            }
            set
            {
                m_livingUID = value;
            }
        }
        
        private sbyte m_livingPosition;
        
        public virtual sbyte LivingPosition
        {
            get
            {
                return m_livingPosition;
            }
            set
            {
                m_livingPosition = value;
            }
        }
        
        private uint m_skinId;
        
        public virtual uint SkinId
        {
            get
            {
                return m_skinId;
            }
            set
            {
                m_skinId = value;
            }
        }
        
        public LivingObjectChangeSkinRequestMessage(uint livingUID, sbyte livingPosition, uint skinId)
        {
            m_livingUID = livingUID;
            m_livingPosition = livingPosition;
            m_skinId = skinId;
        }
        
        public LivingObjectChangeSkinRequestMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhInt(m_livingUID);
            writer.WriteSByte(m_livingPosition);
            writer.WriteVarUhInt(m_skinId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_livingUID = reader.ReadVarUhInt();
            m_livingPosition = reader.ReadSByte();
            m_skinId = reader.ReadVarUhInt();
        }
    }
}