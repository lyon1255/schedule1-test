using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003CA RID: 970
	[Serializable]
	public class FailureToComply : Crime
	{
		// Token: 0x06004B3E RID: 19262 RVA: 0x0016BD90 File Offset: 0x00169F90
		// Note: this type is marked as 'beforefieldinit'.
		static FailureToComply()
		{
			Il2CppClassPointerStore<FailureToComply>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "FailureToComply");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr);
			FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, "<CrimeName>k__BackingField");
			FailureToComply.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100672621);
			FailureToComply.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100672622);
			FailureToComply.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr, 100672623);
		}

		// Token: 0x1700168E RID: 5774
		// (get) Token: 0x06004B3F RID: 19263 RVA: 0x0016BE10 File Offset: 0x0016A010
		// (set) Token: 0x06004B40 RID: 19264 RVA: 0x0016BE54 File Offset: 0x0016A054
		public unsafe override string CrimeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailureToComply.NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FailureToComply.NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x0016BEA4 File Offset: 0x0016A0A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 164683, RefRangeEnd = 164684, XrefRangeStart = 164674, XrefRangeEnd = 164683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FailureToComply() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FailureToComply>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FailureToComply.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x0002436F File Offset: 0x0002256F
		public FailureToComply(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06004B43 RID: 19267 RVA: 0x0016BEE0 File Offset: 0x0016A0E0
		// (set) Token: 0x06004B44 RID: 19268 RVA: 0x00024378 File Offset: 0x00022578
		public new unsafe string _CrimeName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FailureToComply.NativeFieldInfoPtr__CrimeName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040032BF RID: 12991
		private static readonly IntPtr NativeFieldInfoPtr__CrimeName_k__BackingField;

		// Token: 0x040032C0 RID: 12992
		private static readonly IntPtr NativeMethodInfoPtr_get_CrimeName_Public_Virtual_get_String_0;

		// Token: 0x040032C1 RID: 12993
		private static readonly IntPtr NativeMethodInfoPtr_set_CrimeName_Protected_Virtual_set_Void_String_0;

		// Token: 0x040032C2 RID: 12994
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
