using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities
{
	// Token: 0x02000514 RID: 1300
	public class CosmeticPowerLine : MonoBehaviour
	{
		// Token: 0x0600737E RID: 29566 RVA: 0x001F82F0 File Offset: 0x001F64F0
		// Note: this type is marked as 'beforefieldinit'.
		static CosmeticPowerLine()
		{
			Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities", "CosmeticPowerLine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr);
			CosmeticPowerLine.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "startPoint");
			CosmeticPowerLine.NativeFieldInfoPtr_endPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "endPoint");
			CosmeticPowerLine.NativeFieldInfoPtr_segments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "segments");
			CosmeticPowerLine.NativeFieldInfoPtr_LengthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, "LengthFactor");
			CosmeticPowerLine.NativeMethodInfoPtr_Draw_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, 100677821);
			CosmeticPowerLine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr, 100677822);
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x001F8398 File Offset: 0x001F6598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225966, XrefRangeEnd = 225978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Draw()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CosmeticPowerLine.NativeMethodInfoPtr_Draw_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x001F83CC File Offset: 0x001F65CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225978, XrefRangeEnd = 225986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CosmeticPowerLine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CosmeticPowerLine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CosmeticPowerLine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x00036E3E File Offset: 0x0003503E
		public CosmeticPowerLine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002305 RID: 8965
		// (get) Token: 0x06007382 RID: 29570 RVA: 0x001F8408 File Offset: 0x001F6608
		// (set) Token: 0x06007383 RID: 29571 RVA: 0x00036E47 File Offset: 0x00035047
		public unsafe Transform startPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_startPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_startPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002306 RID: 8966
		// (get) Token: 0x06007384 RID: 29572 RVA: 0x001F8438 File Offset: 0x001F6638
		// (set) Token: 0x06007385 RID: 29573 RVA: 0x00036E66 File Offset: 0x00035066
		public unsafe Transform endPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_endPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_endPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002307 RID: 8967
		// (get) Token: 0x06007386 RID: 29574 RVA: 0x001F8468 File Offset: 0x001F6668
		// (set) Token: 0x06007387 RID: 29575 RVA: 0x00036E85 File Offset: 0x00035085
		public unsafe List<Transform> segments
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_segments);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_segments), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002308 RID: 8968
		// (get) Token: 0x06007388 RID: 29576 RVA: 0x001F8498 File Offset: 0x001F6698
		// (set) Token: 0x06007389 RID: 29577 RVA: 0x00036EA4 File Offset: 0x000350A4
		public unsafe float LengthFactor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_LengthFactor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CosmeticPowerLine.NativeFieldInfoPtr_LengthFactor)) = value;
			}
		}

		// Token: 0x04004ED9 RID: 20185
		private static readonly IntPtr NativeFieldInfoPtr_startPoint;

		// Token: 0x04004EDA RID: 20186
		private static readonly IntPtr NativeFieldInfoPtr_endPoint;

		// Token: 0x04004EDB RID: 20187
		private static readonly IntPtr NativeFieldInfoPtr_segments;

		// Token: 0x04004EDC RID: 20188
		private static readonly IntPtr NativeFieldInfoPtr_LengthFactor;

		// Token: 0x04004EDD RID: 20189
		private static readonly IntPtr NativeMethodInfoPtr_Draw_Public_Void_0;

		// Token: 0x04004EDE RID: 20190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
