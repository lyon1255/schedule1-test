using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs.Relation;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200026B RID: 619
	[Serializable]
	public class RelationshipData : SaveData
	{
		// Token: 0x06002F43 RID: 12099 RVA: 0x00107238 File Offset: 0x00105438
		// Note: this type is marked as 'beforefieldinit'.
		static RelationshipData()
		{
			Il2CppClassPointerStore<RelationshipData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "RelationshipData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr);
			RelationshipData.NativeFieldInfoPtr_RelationDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "RelationDelta");
			RelationshipData.NativeFieldInfoPtr_Unlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "Unlocked");
			RelationshipData.NativeFieldInfoPtr_UnlockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, "UnlockType");
			RelationshipData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr, 100668766);
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x001072B8 File Offset: 0x001054B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130610, RefRangeEnd = 130611, XrefRangeStart = 130609, XrefRangeEnd = 130610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RelationshipData(float relationDelta, bool unlocked, NPCRelationData.EUnlockType unlockType) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RelationshipData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref relationDelta;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlocked;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref unlockType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RelationshipData.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x00019018 File Offset: 0x00017218
		public RelationshipData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06002F46 RID: 12102 RVA: 0x0010731C File Offset: 0x0010551C
		// (set) Token: 0x06002F47 RID: 12103 RVA: 0x00019021 File Offset: 0x00017221
		public unsafe float RelationDelta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_RelationDelta);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_RelationDelta)) = value;
			}
		}

		// Token: 0x17000F74 RID: 3956
		// (get) Token: 0x06002F48 RID: 12104 RVA: 0x00107344 File Offset: 0x00105544
		// (set) Token: 0x06002F49 RID: 12105 RVA: 0x0001903C File Offset: 0x0001723C
		public unsafe bool Unlocked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_Unlocked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_Unlocked)) = value;
			}
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x0010736C File Offset: 0x0010556C
		// (set) Token: 0x06002F4B RID: 12107 RVA: 0x00019057 File Offset: 0x00017257
		public unsafe NPCRelationData.EUnlockType UnlockType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_UnlockType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RelationshipData.NativeFieldInfoPtr_UnlockType)) = value;
			}
		}

		// Token: 0x04001F2F RID: 7983
		private static readonly IntPtr NativeFieldInfoPtr_RelationDelta;

		// Token: 0x04001F30 RID: 7984
		private static readonly IntPtr NativeFieldInfoPtr_Unlocked;

		// Token: 0x04001F31 RID: 7985
		private static readonly IntPtr NativeFieldInfoPtr_UnlockType;

		// Token: 0x04001F32 RID: 7986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_EUnlockType_0;
	}
}
