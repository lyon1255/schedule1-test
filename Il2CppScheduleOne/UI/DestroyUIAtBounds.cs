using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066A RID: 1642
	public class DestroyUIAtBounds : MonoBehaviour
	{
		// Token: 0x060092A8 RID: 37544 RVA: 0x0025CEF0 File Offset: 0x0025B0F0
		// Note: this type is marked as 'beforefieldinit'.
		static DestroyUIAtBounds()
		{
			Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DestroyUIAtBounds");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr);
			DestroyUIAtBounds.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "Rect");
			DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "MinBounds");
			DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, "MaxBounds");
			DestroyUIAtBounds.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, 100681500);
			DestroyUIAtBounds.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr, 100681501);
		}

		// Token: 0x060092A9 RID: 37545 RVA: 0x0025CF84 File Offset: 0x0025B184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264676, XrefRangeEnd = 264685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyUIAtBounds.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092AA RID: 37546 RVA: 0x0025CFB8 File Offset: 0x0025B1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264685, XrefRangeEnd = 264686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DestroyUIAtBounds() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DestroyUIAtBounds>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DestroyUIAtBounds.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092AB RID: 37547 RVA: 0x00046FCA File Offset: 0x000451CA
		public DestroyUIAtBounds(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x060092AC RID: 37548 RVA: 0x0025CFF4 File Offset: 0x0025B1F4
		// (set) Token: 0x060092AD RID: 37549 RVA: 0x00046FD3 File Offset: 0x000451D3
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x060092AE RID: 37550 RVA: 0x0025D024 File Offset: 0x0025B224
		// (set) Token: 0x060092AF RID: 37551 RVA: 0x00046FF2 File Offset: 0x000451F2
		public unsafe Vector2 MinBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MinBounds)) = value;
			}
		}

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x060092B0 RID: 37552 RVA: 0x0025D04C File Offset: 0x0025B24C
		// (set) Token: 0x060092B1 RID: 37553 RVA: 0x0004700D File Offset: 0x0004520D
		public unsafe Vector2 MaxBounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DestroyUIAtBounds.NativeFieldInfoPtr_MaxBounds)) = value;
			}
		}

		// Token: 0x04006310 RID: 25360
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006311 RID: 25361
		private static readonly IntPtr NativeFieldInfoPtr_MinBounds;

		// Token: 0x04006312 RID: 25362
		private static readonly IntPtr NativeFieldInfoPtr_MaxBounds;

		// Token: 0x04006313 RID: 25363
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x04006314 RID: 25364
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
