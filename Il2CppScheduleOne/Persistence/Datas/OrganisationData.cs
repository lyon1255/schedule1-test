using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A6 RID: 678
	[Serializable]
	public class OrganisationData : SaveData
	{
		// Token: 0x06003118 RID: 12568 RVA: 0x0010C66C File Offset: 0x0010A86C
		// Note: this type is marked as 'beforefieldinit'.
		static OrganisationData()
		{
			Il2CppClassPointerStore<OrganisationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "OrganisationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr);
			OrganisationData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, "Name");
			OrganisationData.NativeFieldInfoPtr_NetWorth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, "NetWorth");
			OrganisationData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr, 100668827);
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x0010C6D8 File Offset: 0x0010A8D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130978, XrefRangeEnd = 130980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrganisationData(string name, float netWorth) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrganisationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref netWorth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrganisationData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x0001A313 File Offset: 0x00018513
		public OrganisationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x0600311B RID: 12571 RVA: 0x0010C734 File Offset: 0x0010A934
		// (set) Token: 0x0600311C RID: 12572 RVA: 0x0001A31C File Offset: 0x0001851C
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x0600311D RID: 12573 RVA: 0x0010C75C File Offset: 0x0010A95C
		// (set) Token: 0x0600311E RID: 12574 RVA: 0x0001A33B File Offset: 0x0001853B
		public unsafe float NetWorth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_NetWorth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrganisationData.NativeFieldInfoPtr_NetWorth)) = value;
			}
		}

		// Token: 0x04001FFD RID: 8189
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04001FFE RID: 8190
		private static readonly IntPtr NativeFieldInfoPtr_NetWorth;

		// Token: 0x04001FFF RID: 8191
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_0;
	}
}
