using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200004B RID: 75
	public sealed class GetSetAttribute : PropertyAttribute
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x0008299C File Offset: 0x00080B9C
		// Note: this type is marked as 'beforefieldinit'.
		static GetSetAttribute()
		{
			Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "GetSetAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr);
			GetSetAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr, "name");
			GetSetAttribute.NativeFieldInfoPtr_dirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr, "dirty");
			GetSetAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr, 100663871);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00082A08 File Offset: 0x00080C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75777, XrefRangeEnd = 75779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetSetAttribute(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetSetAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetSetAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000059C1 File Offset: 0x00003BC1
		public GetSetAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x00082A54 File Offset: 0x00080C54
		// (set) Token: 0x06000628 RID: 1576 RVA: 0x000059CA File Offset: 0x00003BCA
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000629 RID: 1577 RVA: 0x00082A7C File Offset: 0x00080C7C
		// (set) Token: 0x0600062A RID: 1578 RVA: 0x000059E9 File Offset: 0x00003BE9
		public unsafe bool dirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetAttribute.NativeFieldInfoPtr_dirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetSetAttribute.NativeFieldInfoPtr_dirty)) = value;
			}
		}

		// Token: 0x040003A9 RID: 937
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040003AA RID: 938
		private static readonly IntPtr NativeFieldInfoPtr_dirty;

		// Token: 0x040003AB RID: 939
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
