using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Map;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000410 RID: 1040
	public class DeadDrop : MonoBehaviour
	{
		// Token: 0x06005A46 RID: 23110 RVA: 0x001A3C4C File Offset: 0x001A1E4C
		// Note: this type is marked as 'beforefieldinit'.
		static DeadDrop()
		{
			Il2CppClassPointerStore<DeadDrop>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DeadDrop");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr);
			DeadDrop.NativeFieldInfoPtr_DeadDrops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDrops");
			DeadDrop.NativeFieldInfoPtr_DeadDropName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDropName");
			DeadDrop.NativeFieldInfoPtr_DeadDropDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "DeadDropDescription");
			DeadDrop.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "Storage");
			DeadDrop.NativeFieldInfoPtr_PoI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "PoI");
			DeadDrop.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "Light");
			DeadDrop.NativeFieldInfoPtr_ItemCountVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "ItemCountVariable");
			DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<GUID>k__BackingField");
			DeadDrop.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "BakedGUID");
			DeadDrop.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674790);
			DeadDrop.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674791);
			DeadDrop.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674792);
			DeadDrop.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674793);
			DeadDrop.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674794);
			DeadDrop.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674795);
			DeadDrop.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674796);
			DeadDrop.NativeMethodInfoPtr_OnDestroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674797);
			DeadDrop.NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674798);
			DeadDrop.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674799);
			DeadDrop.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, 100674800);
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x06005A47 RID: 23111 RVA: 0x001A3E0C File Offset: 0x001A200C
		// (set) Token: 0x06005A48 RID: 23112 RVA: 0x001A3E48 File Offset: 0x001A2048
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005A49 RID: 23113 RVA: 0x001A3E88 File Offset: 0x001A2088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190512, XrefRangeEnd = 190515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A4A RID: 23114 RVA: 0x001A3EBC File Offset: 0x001A20BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190515, XrefRangeEnd = 190529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadDrop.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x001A3EF8 File Offset: 0x001A20F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190529, XrefRangeEnd = 190532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x001A3F2C File Offset: 0x001A212C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190532, XrefRangeEnd = 190563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeadDrop.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x001A3F68 File Offset: 0x001A2168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190563, XrefRangeEnd = 190567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x001A3FA8 File Offset: 0x001A21A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190567, XrefRangeEnd = 190575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_OnDestroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x001A3FDC File Offset: 0x001A21DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190626, RefRangeEnd = 190627, XrefRangeStart = 190575, XrefRangeEnd = 190626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DeadDrop GetRandomEmptyDrop(Vector3 origin)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DeadDrop>(intPtr3) : null;
		}

		// Token: 0x06005A50 RID: 23120 RVA: 0x001A401C File Offset: 0x001A221C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190627, XrefRangeEnd = 190639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDeadDrop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A51 RID: 23121 RVA: 0x001A4050 File Offset: 0x001A2250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190639, XrefRangeEnd = 190645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeadDrop() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A52 RID: 23122 RVA: 0x0002AA84 File Offset: 0x00028C84
		public DeadDrop(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x06005A53 RID: 23123 RVA: 0x001A408C File Offset: 0x001A228C
		// (set) Token: 0x06005A54 RID: 23124 RVA: 0x0002AA8D File Offset: 0x00028C8D
		public unsafe static List<DeadDrop> DeadDrops
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DeadDrop.NativeFieldInfoPtr_DeadDrops, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DeadDrop>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DeadDrop.NativeFieldInfoPtr_DeadDrops, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x06005A55 RID: 23125 RVA: 0x001A40B4 File Offset: 0x001A22B4
		// (set) Token: 0x06005A56 RID: 23126 RVA: 0x0002AA9F File Offset: 0x00028C9F
		public unsafe string DeadDropName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x06005A57 RID: 23127 RVA: 0x001A40DC File Offset: 0x001A22DC
		// (set) Token: 0x06005A58 RID: 23128 RVA: 0x0002AABE File Offset: 0x00028CBE
		public unsafe string DeadDropDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_DeadDropDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x06005A59 RID: 23129 RVA: 0x001A4104 File Offset: 0x001A2304
		// (set) Token: 0x06005A5A RID: 23130 RVA: 0x0002AADD File Offset: 0x00028CDD
		public unsafe StorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x06005A5B RID: 23131 RVA: 0x001A4134 File Offset: 0x001A2334
		// (set) Token: 0x06005A5C RID: 23132 RVA: 0x0002AAFC File Offset: 0x00028CFC
		public unsafe POI PoI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_PoI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<POI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_PoI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x06005A5D RID: 23133 RVA: 0x001A4164 File Offset: 0x001A2364
		// (set) Token: 0x06005A5E RID: 23134 RVA: 0x0002AB1B File Offset: 0x00028D1B
		public unsafe OptimizedLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x06005A5F RID: 23135 RVA: 0x001A4194 File Offset: 0x001A2394
		// (set) Token: 0x06005A60 RID: 23136 RVA: 0x0002AB3A File Offset: 0x00028D3A
		public unsafe string ItemCountVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_ItemCountVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_ItemCountVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x06005A61 RID: 23137 RVA: 0x001A41BC File Offset: 0x001A23BC
		// (set) Token: 0x06005A62 RID: 23138 RVA: 0x0002AB59 File Offset: 0x00028D59
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x06005A63 RID: 23139 RVA: 0x001A41E4 File Offset: 0x001A23E4
		// (set) Token: 0x06005A64 RID: 23140 RVA: 0x0002AB74 File Offset: 0x00028D74
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003DA1 RID: 15777
		private static readonly IntPtr NativeFieldInfoPtr_DeadDrops;

		// Token: 0x04003DA2 RID: 15778
		private static readonly IntPtr NativeFieldInfoPtr_DeadDropName;

		// Token: 0x04003DA3 RID: 15779
		private static readonly IntPtr NativeFieldInfoPtr_DeadDropDescription;

		// Token: 0x04003DA4 RID: 15780
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04003DA5 RID: 15781
		private static readonly IntPtr NativeFieldInfoPtr_PoI;

		// Token: 0x04003DA6 RID: 15782
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04003DA7 RID: 15783
		private static readonly IntPtr NativeFieldInfoPtr_ItemCountVariable;

		// Token: 0x04003DA8 RID: 15784
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04003DA9 RID: 15785
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04003DAA RID: 15786
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04003DAB RID: 15787
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04003DAC RID: 15788
		private static readonly IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x04003DAD RID: 15789
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003DAE RID: 15790
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04003DAF RID: 15791
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04003DB0 RID: 15792
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04003DB1 RID: 15793
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Public_Void_0;

		// Token: 0x04003DB2 RID: 15794
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomEmptyDrop_Public_Static_DeadDrop_Vector3_0;

		// Token: 0x04003DB3 RID: 15795
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDeadDrop_Private_Void_0;

		// Token: 0x04003DB4 RID: 15796
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009E3 RID: 2531
		[ObfuscatedName("ScheduleOne.Economy.DeadDrop+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CD46 RID: 52550 RVA: 0x003172CC File Offset: 0x003154CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr);
				DeadDrop.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, "<>9");
				DeadDrop.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, "<>9__18_0");
				DeadDrop.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, 100674803);
				DeadDrop.__c.NativeMethodInfoPtr__GetRandomEmptyDrop_b__18_0_Internal_Boolean_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr, 100674804);
			}

			// Token: 0x0600CD47 RID: 52551 RVA: 0x00317348 File Offset: 0x00315548
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD48 RID: 52552 RVA: 0x00317384 File Offset: 0x00315584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190506, XrefRangeEnd = 190507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetRandomEmptyDrop_b__18_0(DeadDrop drop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c.NativeMethodInfoPtr__GetRandomEmptyDrop_b__18_0_Internal_Boolean_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD49 RID: 52553 RVA: 0x00063D7F File Offset: 0x00061F7F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE8 RID: 16360
			// (get) Token: 0x0600CD4A RID: 52554 RVA: 0x003173D4 File Offset: 0x003155D4
			// (set) Token: 0x0600CD4B RID: 52555 RVA: 0x00063D88 File Offset: 0x00061F88
			public unsafe static DeadDrop.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeadDrop.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DeadDrop.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeadDrop.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE9 RID: 16361
			// (get) Token: 0x0600CD4C RID: 52556 RVA: 0x003173FC File Offset: 0x003155FC
			// (set) Token: 0x0600CD4D RID: 52557 RVA: 0x00063D9A File Offset: 0x00061F9A
			public unsafe static Func<DeadDrop, bool> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DeadDrop.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DeadDrop, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DeadDrop.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AB2 RID: 35506
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008AB3 RID: 35507
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04008AB4 RID: 35508
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AB5 RID: 35509
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomEmptyDrop_b__18_0_Internal_Boolean_DeadDrop_0;
		}

		// Token: 0x020009E4 RID: 2532
		[ObfuscatedName("ScheduleOne.Economy.DeadDrop+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CD4E RID: 52558 RVA: 0x00317424 File Offset: 0x00315624
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DeadDrop>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr);
				DeadDrop.__c__DisplayClass18_0.NativeFieldInfoPtr_origin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr, "origin");
				DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr, 100674805);
				DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr, 100674806);
			}

			// Token: 0x0600CD4F RID: 52559 RVA: 0x0031748C File Offset: 0x0031568C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeadDrop.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD50 RID: 52560 RVA: 0x003174C8 File Offset: 0x003156C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 190507, XrefRangeEnd = 190512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetRandomEmptyDrop_b__1(DeadDrop drop)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(drop);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeadDrop.__c__DisplayClass18_0.NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD51 RID: 52561 RVA: 0x00063DAC File Offset: 0x00061FAC
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FEA RID: 16362
			// (get) Token: 0x0600CD52 RID: 52562 RVA: 0x00317518 File Offset: 0x00315718
			// (set) Token: 0x0600CD53 RID: 52563 RVA: 0x00063DB5 File Offset: 0x00061FB5
			public unsafe Vector3 origin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.__c__DisplayClass18_0.NativeFieldInfoPtr_origin);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeadDrop.__c__DisplayClass18_0.NativeFieldInfoPtr_origin)) = value;
				}
			}

			// Token: 0x04008AB6 RID: 35510
			private static readonly IntPtr NativeFieldInfoPtr_origin;

			// Token: 0x04008AB7 RID: 35511
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AB8 RID: 35512
			private static readonly IntPtr NativeMethodInfoPtr__GetRandomEmptyDrop_b__1_Internal_Single_DeadDrop_0;
		}
	}
}
