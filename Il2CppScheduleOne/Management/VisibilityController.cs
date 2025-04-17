using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A2 RID: 930
	public class VisibilityController : MonoBehaviour
	{
		// Token: 0x060048DB RID: 18651 RVA: 0x00163F48 File Offset: 0x00162148
		// Note: this type is marked as 'beforefieldinit'.
		static VisibilityController()
		{
			Il2CppClassPointerStore<VisibilityController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "VisibilityController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr);
			VisibilityController.NativeFieldInfoPtr_visibleOnlyInFullscreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, "visibleOnlyInFullscreen");
			VisibilityController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672334);
			VisibilityController.NativeMethodInfoPtr_OnEnterFullScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672335);
			VisibilityController.NativeMethodInfoPtr_OnExitFullScreen_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672336);
			VisibilityController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr, 100672337);
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x00163FDC File Offset: 0x001621DC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x00164010 File Offset: 0x00162210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162703, XrefRangeEnd = 162705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnterFullScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr_OnEnterFullScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DE RID: 18654 RVA: 0x00164044 File Offset: 0x00162244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 162705, XrefRangeEnd = 162707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnExitFullScreen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr_OnExitFullScreen_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048DF RID: 18655 RVA: 0x00164078 File Offset: 0x00162278
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 162708, RefRangeEnd = 162724, XrefRangeStart = 162707, XrefRangeEnd = 162708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060048E0 RID: 18656 RVA: 0x000231C9 File Offset: 0x000213C9
		public VisibilityController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x060048E1 RID: 18657 RVA: 0x001640B4 File Offset: 0x001622B4
		// (set) Token: 0x060048E2 RID: 18658 RVA: 0x000231D2 File Offset: 0x000213D2
		public unsafe bool visibleOnlyInFullscreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityController.NativeFieldInfoPtr_visibleOnlyInFullscreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityController.NativeFieldInfoPtr_visibleOnlyInFullscreen)) = value;
			}
		}

		// Token: 0x04003129 RID: 12585
		private static readonly IntPtr NativeFieldInfoPtr_visibleOnlyInFullscreen;

		// Token: 0x0400312A RID: 12586
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400312B RID: 12587
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterFullScreen_Private_Void_0;

		// Token: 0x0400312C RID: 12588
		private static readonly IntPtr NativeMethodInfoPtr_OnExitFullScreen_Private_Void_0;

		// Token: 0x0400312D RID: 12589
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
