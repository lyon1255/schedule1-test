using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace Il2CppScheduleOne.FX
{
	// Token: 0x020003FA RID: 1018
	public class ProximityCircle : MonoBehaviour
	{
		// Token: 0x060054E1 RID: 21729 RVA: 0x0018D1B8 File Offset: 0x0018B3B8
		// Note: this type is marked as 'beforefieldinit'.
		static ProximityCircle()
		{
			Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.FX", "ProximityCircle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr);
			ProximityCircle.NativeFieldInfoPtr_Circle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, "Circle");
			ProximityCircle.NativeFieldInfoPtr_enabledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, "enabledThisFrame");
			ProximityCircle.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673846);
			ProximityCircle.NativeMethodInfoPtr_SetRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673847);
			ProximityCircle.NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673848);
			ProximityCircle.NativeMethodInfoPtr_SetColor_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673849);
			ProximityCircle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr, 100673850);
		}

		// Token: 0x060054E2 RID: 21730 RVA: 0x0018D274 File Offset: 0x0018B474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 180249, XrefRangeEnd = 180251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054E3 RID: 21731 RVA: 0x0018D2A8 File Offset: 0x0018B4A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 180252, RefRangeEnd = 180254, XrefRangeStart = 180251, XrefRangeEnd = 180252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRadius(float rad)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rad;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054E4 RID: 21732 RVA: 0x0018D2E8 File Offset: 0x0018B4E8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 180257, RefRangeEnd = 180264, XrefRangeStart = 180254, XrefRangeEnd = 180257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054E5 RID: 21733 RVA: 0x0018D328 File Offset: 0x0018B528
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 180265, RefRangeEnd = 180269, XrefRangeStart = 180264, XrefRangeEnd = 180265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetColor(Color col)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr_SetColor_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054E6 RID: 21734 RVA: 0x0018D368 File Offset: 0x0018B568
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProximityCircle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProximityCircle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProximityCircle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x00028C0A File Offset: 0x00026E0A
		public ProximityCircle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x060054E8 RID: 21736 RVA: 0x0018D3A4 File Offset: 0x0018B5A4
		// (set) Token: 0x060054E9 RID: 21737 RVA: 0x00028C13 File Offset: 0x00026E13
		public unsafe DecalProjector Circle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_Circle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DecalProjector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_Circle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x060054EA RID: 21738 RVA: 0x0018D3D4 File Offset: 0x0018B5D4
		// (set) Token: 0x060054EB RID: 21739 RVA: 0x00028C32 File Offset: 0x00026E32
		public unsafe bool enabledThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_enabledThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProximityCircle.NativeFieldInfoPtr_enabledThisFrame)) = value;
			}
		}

		// Token: 0x04003971 RID: 14705
		private static readonly IntPtr NativeFieldInfoPtr_Circle;

		// Token: 0x04003972 RID: 14706
		private static readonly IntPtr NativeFieldInfoPtr_enabledThisFrame;

		// Token: 0x04003973 RID: 14707
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003974 RID: 14708
		private static readonly IntPtr NativeMethodInfoPtr_SetRadius_Public_Void_Single_0;

		// Token: 0x04003975 RID: 14709
		private static readonly IntPtr NativeMethodInfoPtr_SetAlpha_Public_Void_Single_0;

		// Token: 0x04003976 RID: 14710
		private static readonly IntPtr NativeMethodInfoPtr_SetColor_Public_Void_Color_0;

		// Token: 0x04003977 RID: 14711
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
