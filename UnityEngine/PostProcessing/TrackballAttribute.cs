using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200004D RID: 77
	public sealed class TrackballAttribute : PropertyAttribute
	{
		// Token: 0x06000630 RID: 1584 RVA: 0x00082B6C File Offset: 0x00080D6C
		// Note: this type is marked as 'beforefieldinit'.
		static TrackballAttribute()
		{
			Il2CppClassPointerStore<TrackballAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "TrackballAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackballAttribute>.NativeClassPtr);
			TrackballAttribute.NativeFieldInfoPtr_method = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackballAttribute>.NativeClassPtr, "method");
			TrackballAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackballAttribute>.NativeClassPtr, 100663873);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00082BC4 File Offset: 0x00080DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackballAttribute(string method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackballAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackballAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00005A28 File Offset: 0x00003C28
		public TrackballAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000633 RID: 1587 RVA: 0x00082C10 File Offset: 0x00080E10
		// (set) Token: 0x06000634 RID: 1588 RVA: 0x00005A31 File Offset: 0x00003C31
		public unsafe string method
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackballAttribute.NativeFieldInfoPtr_method);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackballAttribute.NativeFieldInfoPtr_method), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040003AE RID: 942
		private static readonly IntPtr NativeFieldInfoPtr_method;

		// Token: 0x040003AF RID: 943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
