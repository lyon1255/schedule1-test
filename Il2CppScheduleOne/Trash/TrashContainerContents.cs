using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x0200051F RID: 1311
	public class TrashContainerContents : MonoBehaviour
	{
		// Token: 0x060074C1 RID: 29889 RVA: 0x001FCC54 File Offset: 0x001FAE54
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerContents()
		{
			Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainerContents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr);
			TrashContainerContents.NativeFieldInfoPtr_TrashContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "TrashContainer");
			TrashContainerContents.NativeFieldInfoPtr_ContentsTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "ContentsTransform");
			TrashContainerContents.NativeFieldInfoPtr_VisualsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "VisualsContainer");
			TrashContainerContents.NativeFieldInfoPtr_VisualsMinTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "VisualsMinTransform");
			TrashContainerContents.NativeFieldInfoPtr_VisualsMaxTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "VisualsMaxTransform");
			TrashContainerContents.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "Collider");
			TrashContainerContents.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, 100677979);
			TrashContainerContents.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, 100677980);
			TrashContainerContents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, 100677981);
		}

		// Token: 0x060074C2 RID: 29890 RVA: 0x001FCD38 File Offset: 0x001FAF38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 228047, XrefRangeEnd = 228056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerContents.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x001FCD6C File Offset: 0x001FAF6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 228074, RefRangeEnd = 228075, XrefRangeStart = 228056, XrefRangeEnd = 228074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerContents.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x001FCDA0 File Offset: 0x001FAFA0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerContents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerContents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x0003765D File Offset: 0x0003585D
		public TrashContainerContents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x060074C6 RID: 29894 RVA: 0x001FCDDC File Offset: 0x001FAFDC
		// (set) Token: 0x060074C7 RID: 29895 RVA: 0x00037666 File Offset: 0x00035866
		public unsafe TrashContainer TrashContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_TrashContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_TrashContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x060074C8 RID: 29896 RVA: 0x001FCE0C File Offset: 0x001FB00C
		// (set) Token: 0x060074C9 RID: 29897 RVA: 0x00037685 File Offset: 0x00035885
		public unsafe Transform ContentsTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_ContentsTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_ContentsTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x060074CA RID: 29898 RVA: 0x001FCE3C File Offset: 0x001FB03C
		// (set) Token: 0x060074CB RID: 29899 RVA: 0x000376A4 File Offset: 0x000358A4
		public unsafe Transform VisualsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x060074CC RID: 29900 RVA: 0x001FCE6C File Offset: 0x001FB06C
		// (set) Token: 0x060074CD RID: 29901 RVA: 0x000376C3 File Offset: 0x000358C3
		public unsafe Transform VisualsMinTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMinTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMinTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x060074CE RID: 29902 RVA: 0x001FCE9C File Offset: 0x001FB09C
		// (set) Token: 0x060074CF RID: 29903 RVA: 0x000376E2 File Offset: 0x000358E2
		public unsafe Transform VisualsMaxTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMaxTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMaxTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x060074D0 RID: 29904 RVA: 0x001FCECC File Offset: 0x001FB0CC
		// (set) Token: 0x060074D1 RID: 29905 RVA: 0x00037701 File Offset: 0x00035901
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004FBD RID: 20413
		private static readonly IntPtr NativeFieldInfoPtr_TrashContainer;

		// Token: 0x04004FBE RID: 20414
		private static readonly IntPtr NativeFieldInfoPtr_ContentsTransform;

		// Token: 0x04004FBF RID: 20415
		private static readonly IntPtr NativeFieldInfoPtr_VisualsContainer;

		// Token: 0x04004FC0 RID: 20416
		private static readonly IntPtr NativeFieldInfoPtr_VisualsMinTransform;

		// Token: 0x04004FC1 RID: 20417
		private static readonly IntPtr NativeFieldInfoPtr_VisualsMaxTransform;

		// Token: 0x04004FC2 RID: 20418
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04004FC3 RID: 20419
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04004FC4 RID: 20420
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x04004FC5 RID: 20421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
