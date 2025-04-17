using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000771 RID: 1905
	public class AutoshopAccessZone : NPCPresenceAccessZone
	{
		// Token: 0x0600B4BF RID: 46271 RVA: 0x002CFA38 File Offset: 0x002CDC38
		// Note: this type is marked as 'beforefieldinit'.
		static AutoshopAccessZone()
		{
			Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "AutoshopAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr);
			AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "RollerDoorAnim");
			AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "VehicleDetection");
			AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "rollerDoorOpen");
			AutoshopAccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100685528);
			AutoshopAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100685529);
			AutoshopAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100685530);
		}

		// Token: 0x0600B4C0 RID: 46272 RVA: 0x002CFAE0 File Offset: 0x002CDCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309371, XrefRangeEnd = 309377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoshopAccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4C1 RID: 46273 RVA: 0x002CFB2C File Offset: 0x002CDD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309377, XrefRangeEnd = 309388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoshopAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4C2 RID: 46274 RVA: 0x002CFB68 File Offset: 0x002CDD68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309388, XrefRangeEnd = 309389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoshopAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoshopAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4C3 RID: 46275 RVA: 0x00058AF6 File Offset: 0x00056CF6
		public AutoshopAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x0600B4C4 RID: 46276 RVA: 0x002CFBA4 File Offset: 0x002CDDA4
		// (set) Token: 0x0600B4C5 RID: 46277 RVA: 0x00058AFF File Offset: 0x00056CFF
		public unsafe Animation RollerDoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x0600B4C6 RID: 46278 RVA: 0x002CFBD4 File Offset: 0x002CDDD4
		// (set) Token: 0x0600B4C7 RID: 46279 RVA: 0x00058B1E File Offset: 0x00056D1E
		public unsafe VehicleDetector VehicleDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x0600B4C8 RID: 46280 RVA: 0x002CFC04 File Offset: 0x002CDE04
		// (set) Token: 0x0600B4C9 RID: 46281 RVA: 0x00058B3D File Offset: 0x00056D3D
		public unsafe bool rollerDoorOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen)) = value;
			}
		}

		// Token: 0x040079D0 RID: 31184
		private static readonly IntPtr NativeFieldInfoPtr_RollerDoorAnim;

		// Token: 0x040079D1 RID: 31185
		private static readonly IntPtr NativeFieldInfoPtr_VehicleDetection;

		// Token: 0x040079D2 RID: 31186
		private static readonly IntPtr NativeFieldInfoPtr_rollerDoorOpen;

		// Token: 0x040079D3 RID: 31187
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x040079D4 RID: 31188
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x040079D5 RID: 31189
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
