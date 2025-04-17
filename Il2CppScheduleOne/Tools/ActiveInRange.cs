using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200052A RID: 1322
	public class ActiveInRange : MonoBehaviour
	{
		// Token: 0x0600762C RID: 30252 RVA: 0x002025DC File Offset: 0x002007DC
		// Note: this type is marked as 'beforefieldinit'.
		static ActiveInRange()
		{
			Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ActiveInRange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr);
			ActiveInRange.NativeFieldInfoPtr_Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "Distance");
			ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "ScaleByLODBias");
			ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "ObjectsToActivate");
			ActiveInRange.NativeFieldInfoPtr_Reverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "Reverse");
			ActiveInRange.NativeFieldInfoPtr_isVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, "isVisible");
			ActiveInRange.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, 100678189);
			ActiveInRange.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr, 100678190);
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x00202698 File Offset: 0x00200898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230575, XrefRangeEnd = 230597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveInRange.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x002026CC File Offset: 0x002008CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230597, XrefRangeEnd = 230598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ActiveInRange() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ActiveInRange>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ActiveInRange.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x00037FC6 File Offset: 0x000361C6
		public ActiveInRange(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023C8 RID: 9160
		// (get) Token: 0x06007630 RID: 30256 RVA: 0x00202708 File Offset: 0x00200908
		// (set) Token: 0x06007631 RID: 30257 RVA: 0x00037FCF File Offset: 0x000361CF
		public unsafe float Distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Distance)) = value;
			}
		}

		// Token: 0x170023C9 RID: 9161
		// (get) Token: 0x06007632 RID: 30258 RVA: 0x00202730 File Offset: 0x00200930
		// (set) Token: 0x06007633 RID: 30259 RVA: 0x00037FEA File Offset: 0x000361EA
		public unsafe bool ScaleByLODBias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ScaleByLODBias)) = value;
			}
		}

		// Token: 0x170023CA RID: 9162
		// (get) Token: 0x06007634 RID: 30260 RVA: 0x00202758 File Offset: 0x00200958
		// (set) Token: 0x06007635 RID: 30261 RVA: 0x00038005 File Offset: 0x00036205
		public unsafe Il2CppReferenceArray<GameObject> ObjectsToActivate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_ObjectsToActivate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CB RID: 9163
		// (get) Token: 0x06007636 RID: 30262 RVA: 0x00202788 File Offset: 0x00200988
		// (set) Token: 0x06007637 RID: 30263 RVA: 0x00038024 File Offset: 0x00036224
		public unsafe bool Reverse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Reverse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_Reverse)) = value;
			}
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x06007638 RID: 30264 RVA: 0x002027B0 File Offset: 0x002009B0
		// (set) Token: 0x06007639 RID: 30265 RVA: 0x0003803F File Offset: 0x0003623F
		public unsafe bool isVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_isVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ActiveInRange.NativeFieldInfoPtr_isVisible)) = value;
			}
		}

		// Token: 0x040050C1 RID: 20673
		private static readonly IntPtr NativeFieldInfoPtr_Distance;

		// Token: 0x040050C2 RID: 20674
		private static readonly IntPtr NativeFieldInfoPtr_ScaleByLODBias;

		// Token: 0x040050C3 RID: 20675
		private static readonly IntPtr NativeFieldInfoPtr_ObjectsToActivate;

		// Token: 0x040050C4 RID: 20676
		private static readonly IntPtr NativeFieldInfoPtr_Reverse;

		// Token: 0x040050C5 RID: 20677
		private static readonly IntPtr NativeFieldInfoPtr_isVisible;

		// Token: 0x040050C6 RID: 20678
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040050C7 RID: 20679
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
