using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000464 RID: 1124
	public class PlaceholderBuilding : MonoBehaviour
	{
		// Token: 0x0600618E RID: 24974 RVA: 0x001BCC90 File Offset: 0x001BAE90
		// Note: this type is marked as 'beforefieldinit'.
		static PlaceholderBuilding()
		{
			Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "PlaceholderBuilding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr);
			PlaceholderBuilding.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Name");
			PlaceholderBuilding.NativeFieldInfoPtr_Dimensions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Dimensions");
			PlaceholderBuilding.NativeFieldInfoPtr_AutoGround = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "AutoGround");
			PlaceholderBuilding.NativeFieldInfoPtr_Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Model");
			PlaceholderBuilding.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "Label");
			PlaceholderBuilding.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, "lastFramePosition");
			PlaceholderBuilding.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, 100675694);
			PlaceholderBuilding.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, 100675695);
			PlaceholderBuilding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr, 100675696);
		}

		// Token: 0x0600618F RID: 24975 RVA: 0x001BCD74 File Offset: 0x001BAF74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200898, XrefRangeEnd = 200906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceholderBuilding.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006190 RID: 24976 RVA: 0x001BCDA8 File Offset: 0x001BAFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200906, XrefRangeEnd = 200950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaceholderBuilding.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006191 RID: 24977 RVA: 0x001BCDE4 File Offset: 0x001BAFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200950, XrefRangeEnd = 200953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaceholderBuilding() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaceholderBuilding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaceholderBuilding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006192 RID: 24978 RVA: 0x0002E1C7 File Offset: 0x0002C3C7
		public PlaceholderBuilding(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06006193 RID: 24979 RVA: 0x001BCE20 File Offset: 0x001BB020
		// (set) Token: 0x06006194 RID: 24980 RVA: 0x0002E1D0 File Offset: 0x0002C3D0
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06006195 RID: 24981 RVA: 0x001BCE48 File Offset: 0x001BB048
		// (set) Token: 0x06006196 RID: 24982 RVA: 0x0002E1EF File Offset: 0x0002C3EF
		public unsafe Vector3 Dimensions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Dimensions);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Dimensions)) = value;
			}
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06006197 RID: 24983 RVA: 0x001BCE70 File Offset: 0x001BB070
		// (set) Token: 0x06006198 RID: 24984 RVA: 0x0002E20A File Offset: 0x0002C40A
		public unsafe bool AutoGround
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_AutoGround);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_AutoGround)) = value;
			}
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06006199 RID: 24985 RVA: 0x001BCE98 File Offset: 0x001BB098
		// (set) Token: 0x0600619A RID: 24986 RVA: 0x0002E225 File Offset: 0x0002C425
		public unsafe Transform Model
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Model);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Model), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x0600619B RID: 24987 RVA: 0x001BCEC8 File Offset: 0x001BB0C8
		// (set) Token: 0x0600619C RID: 24988 RVA: 0x0002E244 File Offset: 0x0002C444
		public unsafe TextMeshPro Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_Label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x0600619D RID: 24989 RVA: 0x001BCEF8 File Offset: 0x001BB0F8
		// (set) Token: 0x0600619E RID: 24990 RVA: 0x0002E263 File Offset: 0x0002C463
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaceholderBuilding.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x0400428D RID: 17037
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x0400428E RID: 17038
		private static readonly IntPtr NativeFieldInfoPtr_Dimensions;

		// Token: 0x0400428F RID: 17039
		private static readonly IntPtr NativeFieldInfoPtr_AutoGround;

		// Token: 0x04004290 RID: 17040
		private static readonly IntPtr NativeFieldInfoPtr_Model;

		// Token: 0x04004291 RID: 17041
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04004292 RID: 17042
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04004293 RID: 17043
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004294 RID: 17044
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004295 RID: 17045
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
