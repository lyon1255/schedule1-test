using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.HandheldBin
{
	// Token: 0x0200075E RID: 1886
	public class HandheldBin_Functional : MonoBehaviour
	{
		// Token: 0x0600B359 RID: 45913 RVA: 0x002CBA88 File Offset: 0x002C9C88
		// Note: this type is marked as 'beforefieldinit'.
		static HandheldBin_Functional()
		{
			Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.HandheldBin", "HandheldBin_Functional");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr);
			HandheldBin_Functional.NativeFieldInfoPtr_trash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "trash");
			HandheldBin_Functional.NativeFieldInfoPtr_trash_MinY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "trash_MinY");
			HandheldBin_Functional.NativeFieldInfoPtr_trash_MaxY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "trash_MaxY");
			HandheldBin_Functional.NativeFieldInfoPtr__fillLevel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, "<fillLevel>k__BackingField");
			HandheldBin_Functional.NativeMethodInfoPtr_get_fillLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685412);
			HandheldBin_Functional.NativeMethodInfoPtr_set_fillLevel_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685413);
			HandheldBin_Functional.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685414);
			HandheldBin_Functional.NativeMethodInfoPtr_SetAmount_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685415);
			HandheldBin_Functional.NativeMethodInfoPtr_UpdateTrashVisuals_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685416);
			HandheldBin_Functional.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr, 100685417);
		}

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0600B35A RID: 45914 RVA: 0x002CBB80 File Offset: 0x002C9D80
		// (set) Token: 0x0600B35B RID: 45915 RVA: 0x002CBBBC File Offset: 0x002C9DBC
		public unsafe float fillLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30020, RefRangeEnd = 30021, XrefRangeStart = 30020, XrefRangeEnd = 30021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr_get_fillLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30021, RefRangeEnd = 30023, XrefRangeStart = 30021, XrefRangeEnd = 30023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr_set_fillLevel_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B35C RID: 45916 RVA: 0x002CBBFC File Offset: 0x002C9DFC
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandheldBin_Functional.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B35D RID: 45917 RVA: 0x002CBC38 File Offset: 0x002C9E38
		[CallerCount(0)]
		public unsafe void SetAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr_SetAmount_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B35E RID: 45918 RVA: 0x002CBC78 File Offset: 0x002C9E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308399, XrefRangeEnd = 308402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateTrashVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HandheldBin_Functional.NativeMethodInfoPtr_UpdateTrashVisuals_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B35F RID: 45919 RVA: 0x002CBCB4 File Offset: 0x002C9EB4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HandheldBin_Functional() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HandheldBin_Functional>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HandheldBin_Functional.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B360 RID: 45920 RVA: 0x00057E28 File Offset: 0x00056028
		public HandheldBin_Functional(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0600B361 RID: 45921 RVA: 0x002CBCF0 File Offset: 0x002C9EF0
		// (set) Token: 0x0600B362 RID: 45922 RVA: 0x00057E31 File Offset: 0x00056031
		public unsafe Transform trash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0600B363 RID: 45923 RVA: 0x002CBD20 File Offset: 0x002C9F20
		// (set) Token: 0x0600B364 RID: 45924 RVA: 0x00057E50 File Offset: 0x00056050
		public unsafe float trash_MinY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MinY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MinY)) = value;
			}
		}

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0600B365 RID: 45925 RVA: 0x002CBD48 File Offset: 0x002C9F48
		// (set) Token: 0x0600B366 RID: 45926 RVA: 0x00057E6B File Offset: 0x0005606B
		public unsafe float trash_MaxY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MaxY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr_trash_MaxY)) = value;
			}
		}

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0600B367 RID: 45927 RVA: 0x002CBD70 File Offset: 0x002C9F70
		// (set) Token: 0x0600B368 RID: 45928 RVA: 0x00057E86 File Offset: 0x00056086
		public unsafe float _fillLevel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr__fillLevel_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HandheldBin_Functional.NativeFieldInfoPtr__fillLevel_k__BackingField)) = value;
			}
		}

		// Token: 0x040078FD RID: 30973
		private static readonly IntPtr NativeFieldInfoPtr_trash;

		// Token: 0x040078FE RID: 30974
		private static readonly IntPtr NativeFieldInfoPtr_trash_MinY;

		// Token: 0x040078FF RID: 30975
		private static readonly IntPtr NativeFieldInfoPtr_trash_MaxY;

		// Token: 0x04007900 RID: 30976
		private static readonly IntPtr NativeFieldInfoPtr__fillLevel_k__BackingField;

		// Token: 0x04007901 RID: 30977
		private static readonly IntPtr NativeMethodInfoPtr_get_fillLevel_Public_get_Single_0;

		// Token: 0x04007902 RID: 30978
		private static readonly IntPtr NativeMethodInfoPtr_set_fillLevel_Protected_set_Void_Single_0;

		// Token: 0x04007903 RID: 30979
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007904 RID: 30980
		private static readonly IntPtr NativeMethodInfoPtr_SetAmount_Public_Void_Single_0;

		// Token: 0x04007905 RID: 30981
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTrashVisuals_Protected_Virtual_New_Void_0;

		// Token: 0x04007906 RID: 30982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
