using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005B2 RID: 1458
	public class MixChute : MonoBehaviour
	{
		// Token: 0x06008014 RID: 32788 RVA: 0x00224530 File Offset: 0x00222730
		// Note: this type is marked as 'beforefieldinit'.
		static MixChute()
		{
			Il2CppClassPointerStore<MixChute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "MixChute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixChute>.NativeClassPtr);
			MixChute.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixChute>.NativeClassPtr, "IntObj");
			MixChute.NativeFieldInfoPtr_DoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixChute>.NativeClassPtr, "DoorAnim");
			MixChute.NativeFieldInfoPtr_isDoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixChute>.NativeClassPtr, "isDoorOpen");
			MixChute.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679389);
			MixChute.NativeMethodInfoPtr_UpdateDoor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679390);
			MixChute.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679391);
			MixChute.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679392);
			MixChute.NativeMethodInfoPtr_SetDoorOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679393);
			MixChute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixChute>.NativeClassPtr, 100679394);
		}

		// Token: 0x06008015 RID: 32789 RVA: 0x00224614 File Offset: 0x00222814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243769, XrefRangeEnd = 243777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008016 RID: 32790 RVA: 0x00224648 File Offset: 0x00222848
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 243793, RefRangeEnd = 243794, XrefRangeStart = 243777, XrefRangeEnd = 243793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDoor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_UpdateDoor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008017 RID: 32791 RVA: 0x0022467C File Offset: 0x0022287C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243794, XrefRangeEnd = 243806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008018 RID: 32792 RVA: 0x002246B0 File Offset: 0x002228B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243806, XrefRangeEnd = 243818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008019 RID: 32793 RVA: 0x002246E4 File Offset: 0x002228E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243818, XrefRangeEnd = 243824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDoorOpen(bool isOpen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOpen;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr_SetDoorOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600801A RID: 32794 RVA: 0x00224724 File Offset: 0x00222924
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixChute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixChute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixChute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600801B RID: 32795 RVA: 0x0003CB4B File Offset: 0x0003AD4B
		public MixChute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x0600801C RID: 32796 RVA: 0x00224760 File Offset: 0x00222960
		// (set) Token: 0x0600801D RID: 32797 RVA: 0x0003CB54 File Offset: 0x0003AD54
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x0600801E RID: 32798 RVA: 0x00224790 File Offset: 0x00222990
		// (set) Token: 0x0600801F RID: 32799 RVA: 0x0003CB73 File Offset: 0x0003AD73
		public unsafe Animation DoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_DoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_DoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x06008020 RID: 32800 RVA: 0x002247C0 File Offset: 0x002229C0
		// (set) Token: 0x06008021 RID: 32801 RVA: 0x0003CB92 File Offset: 0x0003AD92
		public unsafe bool isDoorOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_isDoorOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixChute.NativeFieldInfoPtr_isDoorOpen)) = value;
			}
		}

		// Token: 0x04005743 RID: 22339
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04005744 RID: 22340
		private static readonly IntPtr NativeFieldInfoPtr_DoorAnim;

		// Token: 0x04005745 RID: 22341
		private static readonly IntPtr NativeFieldInfoPtr_isDoorOpen;

		// Token: 0x04005746 RID: 22342
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005747 RID: 22343
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDoor_Private_Void_0;

		// Token: 0x04005748 RID: 22344
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04005749 RID: 22345
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x0400574A RID: 22346
		private static readonly IntPtr NativeMethodInfoPtr_SetDoorOpen_Public_Void_Boolean_0;

		// Token: 0x0400574B RID: 22347
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
