using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200004C RID: 76
	public sealed class MinAttribute : PropertyAttribute
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x00082AA4 File Offset: 0x00080CA4
		// Note: this type is marked as 'beforefieldinit'.
		static MinAttribute()
		{
			Il2CppClassPointerStore<MinAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "MinAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr);
			MinAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr, "min");
			MinAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr, 100663872);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00082AFC File Offset: 0x00080CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75779, XrefRangeEnd = 75780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinAttribute(float min) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref min;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00005A04 File Offset: 0x00003C04
		public MinAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00082B44 File Offset: 0x00080D44
		// (set) Token: 0x0600062F RID: 1583 RVA: 0x00005A0D File Offset: 0x00003C0D
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinAttribute.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinAttribute.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x040003AC RID: 940
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040003AD RID: 941
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
