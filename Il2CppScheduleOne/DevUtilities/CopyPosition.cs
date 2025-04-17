using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000452 RID: 1106
	public class CopyPosition : MonoBehaviour
	{
		// Token: 0x06006030 RID: 24624 RVA: 0x001B84AC File Offset: 0x001B66AC
		// Note: this type is marked as 'beforefieldinit'.
		static CopyPosition()
		{
			Il2CppClassPointerStore<CopyPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "CopyPosition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr);
			CopyPosition.NativeFieldInfoPtr_ToCopy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, "ToCopy");
			CopyPosition.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, 100675542);
			CopyPosition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr, 100675543);
		}

		// Token: 0x06006031 RID: 24625 RVA: 0x001B8518 File Offset: 0x001B6718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198879, XrefRangeEnd = 198882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x001B854C File Offset: 0x001B674C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyPosition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyPosition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyPosition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x0002D763 File Offset: 0x0002B963
		public CopyPosition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06006034 RID: 24628 RVA: 0x001B8588 File Offset: 0x001B6788
		// (set) Token: 0x06006035 RID: 24629 RVA: 0x0002D76C File Offset: 0x0002B96C
		public unsafe Transform ToCopy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyPosition.NativeFieldInfoPtr_ToCopy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyPosition.NativeFieldInfoPtr_ToCopy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041AC RID: 16812
		private static readonly IntPtr NativeFieldInfoPtr_ToCopy;

		// Token: 0x040041AD RID: 16813
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040041AE RID: 16814
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
