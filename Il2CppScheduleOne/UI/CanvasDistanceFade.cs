using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000628 RID: 1576
	public class CanvasDistanceFade : MonoBehaviour
	{
		// Token: 0x06008B05 RID: 35589 RVA: 0x00246358 File Offset: 0x00244558
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasDistanceFade()
		{
			Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CanvasDistanceFade");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr);
			CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "CanvasGroup");
			CanvasDistanceFade.NativeFieldInfoPtr_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "MinDistance");
			CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, "MaxDistance");
			CanvasDistanceFade.NativeMethodInfoPtr_LateUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, 100680571);
			CanvasDistanceFade.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr, 100680572);
		}

		// Token: 0x06008B06 RID: 35590 RVA: 0x002463EC File Offset: 0x002445EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254672, XrefRangeEnd = 254689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasDistanceFade.NativeMethodInfoPtr_LateUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B07 RID: 35591 RVA: 0x00246420 File Offset: 0x00244620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 254689, XrefRangeEnd = 254690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasDistanceFade() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasDistanceFade>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasDistanceFade.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B08 RID: 35592 RVA: 0x000428C5 File Offset: 0x00040AC5
		public CanvasDistanceFade(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A61 RID: 10849
		// (get) Token: 0x06008B09 RID: 35593 RVA: 0x0024645C File Offset: 0x0024465C
		// (set) Token: 0x06008B0A RID: 35594 RVA: 0x000428CE File Offset: 0x00040ACE
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A62 RID: 10850
		// (get) Token: 0x06008B0B RID: 35595 RVA: 0x0024648C File Offset: 0x0024468C
		// (set) Token: 0x06008B0C RID: 35596 RVA: 0x000428ED File Offset: 0x00040AED
		public unsafe float MinDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MinDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MinDistance)) = value;
			}
		}

		// Token: 0x17002A63 RID: 10851
		// (get) Token: 0x06008B0D RID: 35597 RVA: 0x002464B4 File Offset: 0x002446B4
		// (set) Token: 0x06008B0E RID: 35598 RVA: 0x00042908 File Offset: 0x00040B08
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasDistanceFade.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x04005E47 RID: 24135
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04005E48 RID: 24136
		private static readonly IntPtr NativeFieldInfoPtr_MinDistance;

		// Token: 0x04005E49 RID: 24137
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x04005E4A RID: 24138
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Public_Void_0;

		// Token: 0x04005E4B RID: 24139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
