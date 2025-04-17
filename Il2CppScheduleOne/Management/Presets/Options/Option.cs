using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management.Presets.Options
{
	// Token: 0x020003AF RID: 943
	public class Option : Object
	{
		// Token: 0x060049AF RID: 18863 RVA: 0x00166BC4 File Offset: 0x00164DC4
		// Note: this type is marked as 'beforefieldinit'.
		static Option()
		{
			Il2CppClassPointerStore<Option>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets.Options", "Option");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Option>.NativeClassPtr);
			Option.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Option>.NativeClassPtr, "<Name>k__BackingField");
			Option.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100672441);
			Option.NativeMethodInfoPtr_set_Name_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100672442);
			Option.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100672443);
			Option.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100672444);
			Option.NativeMethodInfoPtr_GetDisplayString_Public_Abstract_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Option>.NativeClassPtr, 100672445);
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x060049B0 RID: 18864 RVA: 0x00166C6C File Offset: 0x00164E6C
		// (set) Token: 0x060049B1 RID: 18865 RVA: 0x00166CA4 File Offset: 0x00164EA4
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr_set_Name_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x00166CE8 File Offset: 0x00164EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163501, XrefRangeEnd = 163507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Option(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Option>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Option.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x00166D34 File Offset: 0x00164F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163507, XrefRangeEnd = 163509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Option other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Option.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Option_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x00166D84 File Offset: 0x00164F84
		[CallerCount(0)]
		public unsafe virtual string GetDisplayString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Option.NativeMethodInfoPtr_GetDisplayString_Public_Abstract_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x000237EB File Offset: 0x000219EB
		public Option(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001619 RID: 5657
		// (get) Token: 0x060049B6 RID: 18870 RVA: 0x00166DC8 File Offset: 0x00164FC8
		// (set) Token: 0x060049B7 RID: 18871 RVA: 0x000237F4 File Offset: 0x000219F4
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Option.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040031B2 RID: 12722
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x040031B3 RID: 12723
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040031B4 RID: 12724
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Protected_set_Void_String_0;

		// Token: 0x040031B5 RID: 12725
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040031B6 RID: 12726
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Option_0;

		// Token: 0x040031B7 RID: 12727
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayString_Public_Abstract_Virtual_New_String_0;
	}
}
