using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000272 RID: 626
	[Serializable]
	public class BotanistConfigurationData : SaveData
	{
		// Token: 0x06002F71 RID: 12145 RVA: 0x001079D8 File Offset: 0x00105BD8
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfigurationData()
		{
			Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BotanistConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr);
			BotanistConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Bed");
			BotanistConfigurationData.NativeFieldInfoPtr_Supplies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Supplies");
			BotanistConfigurationData.NativeFieldInfoPtr_Pots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, "Pots");
			BotanistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr, 100668774);
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00107A58 File Offset: 0x00105C58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130624, RefRangeEnd = 130626, XrefRangeStart = 130620, XrefRangeEnd = 130624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfigurationData(ObjectFieldData bed, ObjectFieldData supplies, ObjectListFieldData pots) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(supplies);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pots);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x000191E4 File Offset: 0x000173E4
		public BotanistConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06002F74 RID: 12148 RVA: 0x00107AC8 File Offset: 0x00105CC8
		// (set) Token: 0x06002F75 RID: 12149 RVA: 0x000191ED File Offset: 0x000173ED
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x00107AF8 File Offset: 0x00105CF8
		// (set) Token: 0x06002F77 RID: 12151 RVA: 0x0001920C File Offset: 0x0001740C
		public unsafe ObjectFieldData Supplies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Supplies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Supplies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x00107B28 File Offset: 0x00105D28
		// (set) Token: 0x06002F79 RID: 12153 RVA: 0x0001922B File Offset: 0x0001742B
		public unsafe ObjectListFieldData Pots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Pots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigurationData.NativeFieldInfoPtr_Pots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeFieldInfoPtr_Supplies;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeFieldInfoPtr_Pots;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectFieldData_ObjectListFieldData_0;
	}
}
