using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.Misc;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000770 RID: 1904
	public class AccessZone : MonoBehaviour
	{
		// Token: 0x0600B4AA RID: 46250 RVA: 0x002CF6A0 File Offset: 0x002CD8A0
		// Note: this type is marked as 'beforefieldinit'.
		static AccessZone()
		{
			Il2CppClassPointerStore<AccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "AccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccessZone>.NativeClassPtr);
			AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "<IsOpen>k__BackingField");
			AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "AllowExitWhenClosed");
			AccessZone.NativeFieldInfoPtr_AutoCloseDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "AutoCloseDoor");
			AccessZone.NativeFieldInfoPtr_Doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "Doors");
			AccessZone.NativeFieldInfoPtr_Lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "Lights");
			AccessZone.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "onOpen");
			AccessZone.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, "onClose");
			AccessZone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100685523);
			AccessZone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100685524);
			AccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100685525);
			AccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100685526);
			AccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccessZone>.NativeClassPtr, 100685527);
		}

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x0600B4AB RID: 46251 RVA: 0x002CF7C0 File Offset: 0x002CD9C0
		// (set) Token: 0x0600B4AC RID: 46252 RVA: 0x002CF7FC File Offset: 0x002CD9FC
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B4AD RID: 46253 RVA: 0x002CF83C File Offset: 0x002CDA3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309357, RefRangeEnd = 309358, XrefRangeStart = 309357, XrefRangeEnd = 309357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccessZone.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4AE RID: 46254 RVA: 0x002CF878 File Offset: 0x002CDA78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309366, RefRangeEnd = 309367, XrefRangeStart = 309358, XrefRangeEnd = 309366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x002CF8C4 File Offset: 0x002CDAC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 309368, RefRangeEnd = 309371, XrefRangeStart = 309367, XrefRangeEnd = 309368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AccessZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x00058A20 File Offset: 0x00056C20
		public AccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x0600B4B1 RID: 46257 RVA: 0x002CF900 File Offset: 0x002CDB00
		// (set) Token: 0x0600B4B2 RID: 46258 RVA: 0x00058A29 File Offset: 0x00056C29
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x0600B4B3 RID: 46259 RVA: 0x002CF928 File Offset: 0x002CDB28
		// (set) Token: 0x0600B4B4 RID: 46260 RVA: 0x00058A44 File Offset: 0x00056C44
		public unsafe bool AllowExitWhenClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AllowExitWhenClosed)) = value;
			}
		}

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x0600B4B5 RID: 46261 RVA: 0x002CF950 File Offset: 0x002CDB50
		// (set) Token: 0x0600B4B6 RID: 46262 RVA: 0x00058A5F File Offset: 0x00056C5F
		public unsafe bool AutoCloseDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AutoCloseDoor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_AutoCloseDoor)) = value;
			}
		}

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x0600B4B7 RID: 46263 RVA: 0x002CF978 File Offset: 0x002CDB78
		// (set) Token: 0x0600B4B8 RID: 46264 RVA: 0x00058A7A File Offset: 0x00056C7A
		public unsafe Il2CppReferenceArray<DoorController> Doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DoorController>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x0600B4B9 RID: 46265 RVA: 0x002CF9A8 File Offset: 0x002CDBA8
		// (set) Token: 0x0600B4BA RID: 46266 RVA: 0x00058A99 File Offset: 0x00056C99
		public unsafe Il2CppReferenceArray<ToggleableLight> Lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ToggleableLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_Lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x0600B4BB RID: 46267 RVA: 0x002CF9D8 File Offset: 0x002CDBD8
		// (set) Token: 0x0600B4BC RID: 46268 RVA: 0x00058AB8 File Offset: 0x00056CB8
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x0600B4BD RID: 46269 RVA: 0x002CFA08 File Offset: 0x002CDC08
		// (set) Token: 0x0600B4BE RID: 46270 RVA: 0x00058AD7 File Offset: 0x00056CD7
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AccessZone.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040079C4 RID: 31172
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040079C5 RID: 31173
		private static readonly IntPtr NativeFieldInfoPtr_AllowExitWhenClosed;

		// Token: 0x040079C6 RID: 31174
		private static readonly IntPtr NativeFieldInfoPtr_AutoCloseDoor;

		// Token: 0x040079C7 RID: 31175
		private static readonly IntPtr NativeFieldInfoPtr_Doors;

		// Token: 0x040079C8 RID: 31176
		private static readonly IntPtr NativeFieldInfoPtr_Lights;

		// Token: 0x040079C9 RID: 31177
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x040079CA RID: 31178
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x040079CB RID: 31179
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040079CC RID: 31180
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040079CD RID: 31181
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040079CE RID: 31182
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040079CF RID: 31183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
