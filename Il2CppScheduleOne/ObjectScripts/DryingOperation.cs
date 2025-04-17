using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000743 RID: 1859
	[Serializable]
	public class DryingOperation : Object
	{
		// Token: 0x0600AC97 RID: 44183 RVA: 0x002B100C File Offset: 0x002AF20C
		// Note: this type is marked as 'beforefieldinit'.
		static DryingOperation()
		{
			Il2CppClassPointerStore<DryingOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "DryingOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr);
			DryingOperation.NativeFieldInfoPtr_ItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "ItemID");
			DryingOperation.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "Quantity");
			DryingOperation.NativeFieldInfoPtr_StartQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "StartQuality");
			DryingOperation.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, "Time");
			DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100684474);
			DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100684475);
			DryingOperation.NativeMethodInfoPtr_IncreaseQuality_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100684476);
			DryingOperation.NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100684477);
			DryingOperation.NativeMethodInfoPtr_GetQuality_Public_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr, 100684478);
		}

		// Token: 0x0600AC98 RID: 44184 RVA: 0x002B10F0 File Offset: 0x002AF2F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298684, XrefRangeEnd = 298686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperation(string itemID, int quantity, EQuality startQuality, int time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(itemID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startQuality;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC99 RID: 44185 RVA: 0x002B1168 File Offset: 0x002AF368
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingOperation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC9A RID: 44186 RVA: 0x002B11A4 File Offset: 0x002AF3A4
		[CallerCount(0)]
		public unsafe void IncreaseQuality()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_IncreaseQuality_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC9B RID: 44187 RVA: 0x002B11D8 File Offset: 0x002AF3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298690, RefRangeEnd = 298691, XrefRangeStart = 298686, XrefRangeEnd = 298690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemInstance GetQualityItemInstance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600AC9C RID: 44188 RVA: 0x002B1218 File Offset: 0x002AF418
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 298691, RefRangeEnd = 298696, XrefRangeStart = 298691, XrefRangeEnd = 298691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EQuality GetQuality()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingOperation.NativeMethodInfoPtr_GetQuality_Public_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AC9D RID: 44189 RVA: 0x00054EAD File Offset: 0x000530AD
		public DryingOperation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0600AC9E RID: 44190 RVA: 0x002B1254 File Offset: 0x002AF454
		// (set) Token: 0x0600AC9F RID: 44191 RVA: 0x00054EB6 File Offset: 0x000530B6
		public unsafe string ItemID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_ItemID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_ItemID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x0600ACA0 RID: 44192 RVA: 0x002B127C File Offset: 0x002AF47C
		// (set) Token: 0x0600ACA1 RID: 44193 RVA: 0x00054ED5 File Offset: 0x000530D5
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0600ACA2 RID: 44194 RVA: 0x002B12A4 File Offset: 0x002AF4A4
		// (set) Token: 0x0600ACA3 RID: 44195 RVA: 0x00054EF0 File Offset: 0x000530F0
		public unsafe EQuality StartQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_StartQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_StartQuality)) = value;
			}
		}

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0600ACA4 RID: 44196 RVA: 0x002B12CC File Offset: 0x002AF4CC
		// (set) Token: 0x0600ACA5 RID: 44197 RVA: 0x00054F0B File Offset: 0x0005310B
		public unsafe int Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingOperation.NativeFieldInfoPtr_Time)) = value;
			}
		}

		// Token: 0x04007405 RID: 29701
		private static readonly IntPtr NativeFieldInfoPtr_ItemID;

		// Token: 0x04007406 RID: 29702
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x04007407 RID: 29703
		private static readonly IntPtr NativeFieldInfoPtr_StartQuality;

		// Token: 0x04007408 RID: 29704
		private static readonly IntPtr NativeFieldInfoPtr_Time;

		// Token: 0x04007409 RID: 29705
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_EQuality_Int32_0;

		// Token: 0x0400740A RID: 29706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400740B RID: 29707
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseQuality_Public_Void_0;

		// Token: 0x0400740C RID: 29708
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityItemInstance_Public_QualityItemInstance_0;

		// Token: 0x0400740D RID: 29709
		private static readonly IntPtr NativeMethodInfoPtr_GetQuality_Public_EQuality_0;
	}
}
