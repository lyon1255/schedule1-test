using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000483 RID: 1155
	public class GenericOption : MonoBehaviour
	{
		// Token: 0x06006437 RID: 25655 RVA: 0x001C5A4C File Offset: 0x001C3C4C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericOption()
		{
			Il2CppClassPointerStore<GenericOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "GenericOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericOption>.NativeClassPtr);
			GenericOption.NativeFieldInfoPtr_optionName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "optionName");
			GenericOption.NativeFieldInfoPtr_optionButtonColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "optionButtonColor");
			GenericOption.NativeFieldInfoPtr_optionPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "optionPrice");
			GenericOption.NativeFieldInfoPtr_onInstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onInstalled");
			GenericOption.NativeFieldInfoPtr_onUninstalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onUninstalled");
			GenericOption.NativeFieldInfoPtr_onSetVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onSetVisible");
			GenericOption.NativeFieldInfoPtr_onSetInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, "onSetInvisible");
			GenericOption.NativeMethodInfoPtr_Install_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676000);
			GenericOption.NativeMethodInfoPtr_Uninstall_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676001);
			GenericOption.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676002);
			GenericOption.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676003);
			GenericOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericOption>.NativeClassPtr, 100676004);
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x001C5B6C File Offset: 0x001C3D6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204058, XrefRangeEnd = 204059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Install()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_Install_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006439 RID: 25657 RVA: 0x001C5BA8 File Offset: 0x001C3DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204059, XrefRangeEnd = 204060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Uninstall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_Uninstall_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x001C5BE4 File Offset: 0x001C3DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204060, XrefRangeEnd = 204061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetVisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x001C5C20 File Offset: 0x001C3E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204061, XrefRangeEnd = 204062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetInvisible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericOption.NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643C RID: 25660 RVA: 0x001C5C5C File Offset: 0x001C3E5C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericOption>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600643D RID: 25661 RVA: 0x0002F646 File Offset: 0x0002D846
		public GenericOption(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x0600643E RID: 25662 RVA: 0x001C5C98 File Offset: 0x001C3E98
		// (set) Token: 0x0600643F RID: 25663 RVA: 0x0002F64F File Offset: 0x0002D84F
		public unsafe string optionName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x06006440 RID: 25664 RVA: 0x001C5CC0 File Offset: 0x001C3EC0
		// (set) Token: 0x06006441 RID: 25665 RVA: 0x0002F66E File Offset: 0x0002D86E
		public unsafe Color optionButtonColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionButtonColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionButtonColor)) = value;
			}
		}

		// Token: 0x17001E39 RID: 7737
		// (get) Token: 0x06006442 RID: 25666 RVA: 0x001C5CE8 File Offset: 0x001C3EE8
		// (set) Token: 0x06006443 RID: 25667 RVA: 0x0002F689 File Offset: 0x0002D889
		public unsafe float optionPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_optionPrice)) = value;
			}
		}

		// Token: 0x17001E3A RID: 7738
		// (get) Token: 0x06006444 RID: 25668 RVA: 0x001C5D10 File Offset: 0x001C3F10
		// (set) Token: 0x06006445 RID: 25669 RVA: 0x0002F6A4 File Offset: 0x0002D8A4
		public unsafe UnityEvent onInstalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onInstalled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onInstalled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E3B RID: 7739
		// (get) Token: 0x06006446 RID: 25670 RVA: 0x001C5D40 File Offset: 0x001C3F40
		// (set) Token: 0x06006447 RID: 25671 RVA: 0x0002F6C3 File Offset: 0x0002D8C3
		public unsafe UnityEvent onUninstalled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onUninstalled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onUninstalled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E3C RID: 7740
		// (get) Token: 0x06006448 RID: 25672 RVA: 0x001C5D70 File Offset: 0x001C3F70
		// (set) Token: 0x06006449 RID: 25673 RVA: 0x0002F6E2 File Offset: 0x0002D8E2
		public unsafe UnityEvent onSetVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetVisible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetVisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E3D RID: 7741
		// (get) Token: 0x0600644A RID: 25674 RVA: 0x001C5DA0 File Offset: 0x001C3FA0
		// (set) Token: 0x0600644B RID: 25675 RVA: 0x0002F701 File Offset: 0x0002D901
		public unsafe UnityEvent onSetInvisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetInvisible);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericOption.NativeFieldInfoPtr_onSetInvisible), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004464 RID: 17508
		private static readonly IntPtr NativeFieldInfoPtr_optionName;

		// Token: 0x04004465 RID: 17509
		private static readonly IntPtr NativeFieldInfoPtr_optionButtonColor;

		// Token: 0x04004466 RID: 17510
		private static readonly IntPtr NativeFieldInfoPtr_optionPrice;

		// Token: 0x04004467 RID: 17511
		private static readonly IntPtr NativeFieldInfoPtr_onInstalled;

		// Token: 0x04004468 RID: 17512
		private static readonly IntPtr NativeFieldInfoPtr_onUninstalled;

		// Token: 0x04004469 RID: 17513
		private static readonly IntPtr NativeFieldInfoPtr_onSetVisible;

		// Token: 0x0400446A RID: 17514
		private static readonly IntPtr NativeFieldInfoPtr_onSetInvisible;

		// Token: 0x0400446B RID: 17515
		private static readonly IntPtr NativeMethodInfoPtr_Install_Public_Virtual_New_Void_0;

		// Token: 0x0400446C RID: 17516
		private static readonly IntPtr NativeMethodInfoPtr_Uninstall_Public_Virtual_New_Void_0;

		// Token: 0x0400446D RID: 17517
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Virtual_New_Void_0;

		// Token: 0x0400446E RID: 17518
		private static readonly IntPtr NativeMethodInfoPtr_SetInvisible_Public_Virtual_New_Void_0;

		// Token: 0x0400446F RID: 17519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
