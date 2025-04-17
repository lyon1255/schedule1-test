using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000282 RID: 642
	[Serializable]
	public class PotConfigurationData : SaveData
	{
		// Token: 0x06002FD3 RID: 12243 RVA: 0x00108A04 File Offset: 0x00106C04
		// Note: this type is marked as 'beforefieldinit'.
		static PotConfigurationData()
		{
			Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PotConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr);
			PotConfigurationData.NativeFieldInfoPtr_Seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Seed");
			PotConfigurationData.NativeFieldInfoPtr_Additive1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive1");
			PotConfigurationData.NativeFieldInfoPtr_Additive2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive2");
			PotConfigurationData.NativeFieldInfoPtr_Additive3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Additive3");
			PotConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, "Destination");
			PotConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr, 100668790);
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x00108AAC File Offset: 0x00106CAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130788, RefRangeEnd = 130789, XrefRangeStart = 130782, XrefRangeEnd = 130788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotConfigurationData(ItemFieldData seed, ItemFieldData additive1, ItemFieldData additive2, ItemFieldData additive3, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(seed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additive3);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x00019577 File Offset: 0x00017777
		public PotConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06002FD6 RID: 12246 RVA: 0x00108B44 File Offset: 0x00106D44
		// (set) Token: 0x06002FD7 RID: 12247 RVA: 0x00019580 File Offset: 0x00017780
		public unsafe ItemFieldData Seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Seed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Seed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06002FD8 RID: 12248 RVA: 0x00108B74 File Offset: 0x00106D74
		// (set) Token: 0x06002FD9 RID: 12249 RVA: 0x0001959F File Offset: 0x0001779F
		public unsafe ItemFieldData Additive1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06002FDA RID: 12250 RVA: 0x00108BA4 File Offset: 0x00106DA4
		// (set) Token: 0x06002FDB RID: 12251 RVA: 0x000195BE File Offset: 0x000177BE
		public unsafe ItemFieldData Additive2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06002FDC RID: 12252 RVA: 0x00108BD4 File Offset: 0x00106DD4
		// (set) Token: 0x06002FDD RID: 12253 RVA: 0x000195DD File Offset: 0x000177DD
		public unsafe ItemFieldData Additive3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Additive3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x06002FDE RID: 12254 RVA: 0x00108C04 File Offset: 0x00106E04
		// (set) Token: 0x06002FDF RID: 12255 RVA: 0x000195FC File Offset: 0x000177FC
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F6C RID: 8044
		private static readonly IntPtr NativeFieldInfoPtr_Seed;

		// Token: 0x04001F6D RID: 8045
		private static readonly IntPtr NativeFieldInfoPtr_Additive1;

		// Token: 0x04001F6E RID: 8046
		private static readonly IntPtr NativeFieldInfoPtr_Additive2;

		// Token: 0x04001F6F RID: 8047
		private static readonly IntPtr NativeFieldInfoPtr_Additive3;

		// Token: 0x04001F70 RID: 8048
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F71 RID: 8049
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemFieldData_ItemFieldData_ItemFieldData_ItemFieldData_ObjectFieldData_0;
	}
}
