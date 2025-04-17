using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006DD RID: 1757
	public class MixingStationUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DCE RID: 40398 RVA: 0x0027E664 File Offset: 0x0027C864
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationUIElement()
		{
			Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "MixingStationUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr);
			MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, "<AssignedStation>k__BackingField");
			MixingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100682651);
			MixingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100682652);
			MixingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100682653);
			MixingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100682654);
			MixingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr, 100682655);
		}

		// Token: 0x1700309A RID: 12442
		// (get) Token: 0x06009DCF RID: 40399 RVA: 0x0027E70C File Offset: 0x0027C90C
		// (set) Token: 0x06009DD0 RID: 40400 RVA: 0x0027E74C File Offset: 0x0027C94C
		public unsafe MixingStation AssignedStation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DD1 RID: 40401 RVA: 0x0027E790 File Offset: 0x0027C990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279550, RefRangeEnd = 279551, XrefRangeStart = 279540, XrefRangeEnd = 279550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DD2 RID: 40402 RVA: 0x0027E7D4 File Offset: 0x0027C9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279551, XrefRangeEnd = 279557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DD3 RID: 40403 RVA: 0x0027E810 File Offset: 0x0027CA10
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DD4 RID: 40404 RVA: 0x0004D6B1 File Offset: 0x0004B8B1
		public MixingStationUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003099 RID: 12441
		// (get) Token: 0x06009DD5 RID: 40405 RVA: 0x0027E84C File Offset: 0x0027CA4C
		// (set) Token: 0x06009DD6 RID: 40406 RVA: 0x0004D6BA File Offset: 0x0004B8BA
		public unsafe MixingStation _AssignedStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationUIElement.NativeFieldInfoPtr__AssignedStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069F3 RID: 27123
		private static readonly IntPtr NativeFieldInfoPtr__AssignedStation_k__BackingField;

		// Token: 0x040069F4 RID: 27124
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStation_Public_get_MixingStation_0;

		// Token: 0x040069F5 RID: 27125
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedStation_Protected_set_Void_MixingStation_0;

		// Token: 0x040069F6 RID: 27126
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_MixingStation_0;

		// Token: 0x040069F7 RID: 27127
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069F8 RID: 27128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
