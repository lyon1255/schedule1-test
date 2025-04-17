using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CB RID: 971
	[Serializable]
	public class TransportingIllicitItems : Crime
	{
		// Token: 0x06004B45 RID: 19269 RVA: 0x0016BF08 File Offset: 0x0016A108
		// Note: this type is marked as 'beforefieldinit'.
		static TransportingIllicitItems()
		{
			Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "TransportingIllicitItems");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr);
			TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, "<CrimeName>k__BackingField");
			TransportingIllicitItems.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100672624);
			TransportingIllicitItems.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100672625);
			TransportingIllicitItems.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr, 100672626);
		}

		// Token: 0x17001690 RID: 5776
		// (get) Token: 0x06004B46 RID: 19270 RVA: 0x0016BF88 File Offset: 0x0016A188
		// (set) Token: 0x06004B47 RID: 19271 RVA: 0x0016BFCC File Offset: 0x0016A1CC
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransportingIllicitItems.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransportingIllicitItems.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x0016C01C File Offset: 0x0016A21C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164693, RefRangeEnd = 164694, XrefRangeStart = 164684, XrefRangeEnd = 164693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransportingIllicitItems() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransportingIllicitItems>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransportingIllicitItems.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x00024397 File Offset: 0x00022597
		public TransportingIllicitItems(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700168F RID: 5775
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x0016C058 File Offset: 0x0016A258
		// (set) Token: 0x06004B4B RID: 19275 RVA: 0x000243A0 File Offset: 0x000225A0
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransportingIllicitItems.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032C3 RID: 12995
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032C4 RID: 12996
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032C5 RID: 12997
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032C6 RID: 12998
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
