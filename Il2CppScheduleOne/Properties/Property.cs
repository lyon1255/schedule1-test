using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Properties
{
	// Token: 0x020001F0 RID: 496
	public class Property : ScriptableObject
	{
		// Token: 0x0600284B RID: 10315 RVA: 0x000EFE68 File Offset: 0x000EE068
		// Note: this type is marked as 'beforefieldinit'.
		static Property()
		{
			Il2CppClassPointerStore<Property>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties", "Property");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Property>.NativeClassPtr);
			Property.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Name");
			Property.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Description");
			Property.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ID");
			Property.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Tier");
			Property.NativeFieldInfoPtr_Addictiveness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "Addictiveness");
			Property.NativeFieldInfoPtr_ProductColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ProductColor");
			Property.NativeFieldInfoPtr_LabelColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "LabelColor");
			Property.NativeFieldInfoPtr_ImplementedPriorMixingRework = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ImplementedPriorMixingRework");
			Property.NativeFieldInfoPtr_ValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ValueChange");
			Property.NativeFieldInfoPtr_ValueMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "ValueMultiplier");
			Property.NativeFieldInfoPtr_AddBaseValueMultiple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "AddBaseValueMultiple");
			Property.NativeFieldInfoPtr_MixDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "MixDirection");
			Property.NativeFieldInfoPtr_MixMagnitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Property>.NativeClassPtr, "MixMagnitude");
			Property.NativeMethodInfoPtr_ApplyToNPC_Public_Abstract_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667852);
			Property.NativeMethodInfoPtr_ClearFromNPC_Public_Abstract_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667853);
			Property.NativeMethodInfoPtr_ApplyToPlayer_Public_Abstract_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667854);
			Property.NativeMethodInfoPtr_ClearFromPlayer_Public_Abstract_Virtual_New_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667855);
			Property.NativeMethodInfoPtr_OnValidate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667856);
			Property.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Property>.NativeClassPtr, 100667857);
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x000F0014 File Offset: 0x000EE214
		[CallerCount(0)]
		public unsafe virtual void ApplyToNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ApplyToNPC_Public_Abstract_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x000F0064 File Offset: 0x000EE264
		[CallerCount(0)]
		public unsafe virtual void ClearFromNPC(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ClearFromNPC_Public_Abstract_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x000F00B4 File Offset: 0x000EE2B4
		[CallerCount(0)]
		public unsafe virtual void ApplyToPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ApplyToPlayer_Public_Abstract_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x000F0104 File Offset: 0x000EE304
		[CallerCount(0)]
		public unsafe virtual void ClearFromPlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Property.NativeMethodInfoPtr_ClearFromPlayer_Public_Abstract_Virtual_New_Void_Player_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x000F0154 File Offset: 0x000EE354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 118347, XrefRangeEnd = 118357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr_OnValidate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x000F0188 File Offset: 0x000EE388
		[CallerCount(35)]
		[CachedScanResults(RefRangeStart = 118367, RefRangeEnd = 118402, XrefRangeStart = 118357, XrefRangeEnd = 118367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Property() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Property>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Property.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x00015E6A File Offset: 0x0001406A
		public Property(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x000F01C4 File Offset: 0x000EE3C4
		// (set) Token: 0x06002854 RID: 10324 RVA: 0x00015E73 File Offset: 0x00014073
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002855 RID: 10325 RVA: 0x000F01EC File Offset: 0x000EE3EC
		// (set) Token: 0x06002856 RID: 10326 RVA: 0x00015E92 File Offset: 0x00014092
		public unsafe string Description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002857 RID: 10327 RVA: 0x000F0214 File Offset: 0x000EE414
		// (set) Token: 0x06002858 RID: 10328 RVA: 0x00015EB1 File Offset: 0x000140B1
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002859 RID: 10329 RVA: 0x000F023C File Offset: 0x000EE43C
		// (set) Token: 0x0600285A RID: 10330 RVA: 0x00015ED0 File Offset: 0x000140D0
		public unsafe int Tier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Tier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Tier)) = value;
			}
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x0600285B RID: 10331 RVA: 0x000F0264 File Offset: 0x000EE464
		// (set) Token: 0x0600285C RID: 10332 RVA: 0x00015EEB File Offset: 0x000140EB
		public unsafe float Addictiveness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Addictiveness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_Addictiveness)) = value;
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x0600285D RID: 10333 RVA: 0x000F028C File Offset: 0x000EE48C
		// (set) Token: 0x0600285E RID: 10334 RVA: 0x00015F06 File Offset: 0x00014106
		public unsafe Color ProductColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ProductColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ProductColor)) = value;
			}
		}

		// Token: 0x17000D79 RID: 3449
		// (get) Token: 0x0600285F RID: 10335 RVA: 0x000F02B4 File Offset: 0x000EE4B4
		// (set) Token: 0x06002860 RID: 10336 RVA: 0x00015F21 File Offset: 0x00014121
		public unsafe Color LabelColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_LabelColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_LabelColor)) = value;
			}
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x06002861 RID: 10337 RVA: 0x000F02DC File Offset: 0x000EE4DC
		// (set) Token: 0x06002862 RID: 10338 RVA: 0x00015F3C File Offset: 0x0001413C
		public unsafe bool ImplementedPriorMixingRework
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ImplementedPriorMixingRework);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ImplementedPriorMixingRework)) = value;
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002863 RID: 10339 RVA: 0x000F0304 File Offset: 0x000EE504
		// (set) Token: 0x06002864 RID: 10340 RVA: 0x00015F57 File Offset: 0x00014157
		public unsafe int ValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ValueChange)) = value;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x06002865 RID: 10341 RVA: 0x000F032C File Offset: 0x000EE52C
		// (set) Token: 0x06002866 RID: 10342 RVA: 0x00015F72 File Offset: 0x00014172
		public unsafe float ValueMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ValueMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_ValueMultiplier)) = value;
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x06002867 RID: 10343 RVA: 0x000F0354 File Offset: 0x000EE554
		// (set) Token: 0x06002868 RID: 10344 RVA: 0x00015F8D File Offset: 0x0001418D
		public unsafe float AddBaseValueMultiple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_AddBaseValueMultiple);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_AddBaseValueMultiple)) = value;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x06002869 RID: 10345 RVA: 0x000F037C File Offset: 0x000EE57C
		// (set) Token: 0x0600286A RID: 10346 RVA: 0x00015FA8 File Offset: 0x000141A8
		public unsafe Vector2 MixDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MixDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MixDirection)) = value;
			}
		}

		// Token: 0x17000D7F RID: 3455
		// (get) Token: 0x0600286B RID: 10347 RVA: 0x000F03A4 File Offset: 0x000EE5A4
		// (set) Token: 0x0600286C RID: 10348 RVA: 0x00015FC3 File Offset: 0x000141C3
		public unsafe float MixMagnitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MixMagnitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Property.NativeFieldInfoPtr_MixMagnitude)) = value;
			}
		}

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeFieldInfoPtr_Description;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeFieldInfoPtr_Tier;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeFieldInfoPtr_Addictiveness;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeFieldInfoPtr_ProductColor;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeFieldInfoPtr_LabelColor;

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeFieldInfoPtr_ImplementedPriorMixingRework;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeFieldInfoPtr_ValueChange;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeFieldInfoPtr_ValueMultiplier;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeFieldInfoPtr_AddBaseValueMultiple;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeFieldInfoPtr_MixDirection;

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeFieldInfoPtr_MixMagnitude;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToNPC_Public_Abstract_Virtual_New_Void_NPC_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromNPC_Public_Abstract_Virtual_New_Void_NPC_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_ApplyToPlayer_Public_Abstract_Virtual_New_Void_Player_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr_ClearFromPlayer_Public_Abstract_Virtual_New_Void_Player_0;

		// Token: 0x04001AD5 RID: 6869
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Public_Void_0;

		// Token: 0x04001AD6 RID: 6870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
