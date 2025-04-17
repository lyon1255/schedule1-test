using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Dialogue;
using Il2CppScheduleOne.Levelling;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000331 RID: 817
	public class Ray : NPC
	{
		// Token: 0x06003C3B RID: 15419 RVA: 0x00134498 File Offset: 0x00132698
		// Note: this type is marked as 'beforefieldinit'.
		static Ray()
		{
			Il2CppClassPointerStore<Ray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Ray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ray>.NativeClassPtr);
			Ray.NativeFieldInfoPtr_GreetingDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "GreetingDialogue");
			Ray.NativeFieldInfoPtr_GreetedVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "GreetedVariable");
			Ray.NativeFieldInfoPtr_IntroductionMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "IntroductionMessage");
			Ray.NativeFieldInfoPtr_IntroSentVariable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "IntroSentVariable");
			Ray.NativeFieldInfoPtr_IntroRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "IntroRank");
			Ray.NativeFieldInfoPtr_IntroDaysPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "IntroDaysPlayed");
			Ray.NativeFieldInfoPtr_IntroNetworth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "IntroNetworth");
			Ray.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.RayAssembly-CSharp.dll_Excuted");
			Ray.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Ray>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.RayAssembly-CSharp.dll_Excuted");
			Ray.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670323);
			Ray.NativeMethodInfoPtr_Loaded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670324);
			Ray.NativeMethodInfoPtr_EnableGreeting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670325);
			Ray.NativeMethodInfoPtr_SetGreeted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670326);
			Ray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670327);
			Ray.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670328);
			Ray.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670329);
			Ray.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670330);
			Ray.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ray>.NativeClassPtr, 100670331);
		}

		// Token: 0x06003C3C RID: 15420 RVA: 0x00134630 File Offset: 0x00132830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142768, XrefRangeEnd = 142781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ray.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C3D RID: 15421 RVA: 0x0013466C File Offset: 0x0013286C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142781, XrefRangeEnd = 142810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Loaded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_Loaded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C3E RID: 15422 RVA: 0x001346A0 File Offset: 0x001328A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142810, XrefRangeEnd = 142822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableGreeting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_EnableGreeting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x001346D4 File Offset: 0x001328D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142822, XrefRangeEnd = 142842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGreeted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr_SetGreeted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C40 RID: 15424 RVA: 0x00134708 File Offset: 0x00132908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142842, XrefRangeEnd = 142851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ray() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x00134744 File Offset: 0x00132944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142851, XrefRangeEnd = 142852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ray.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x00134780 File Offset: 0x00132980
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142852, XrefRangeEnd = 142853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ray.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x001347BC File Offset: 0x001329BC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ray.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x001347F8 File Offset: 0x001329F8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ray.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x0001E8C6 File Offset: 0x0001CAC6
		public Ray(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06003C46 RID: 15430 RVA: 0x00134834 File Offset: 0x00132A34
		// (set) Token: 0x06003C47 RID: 15431 RVA: 0x0001E8CF File Offset: 0x0001CACF
		public unsafe DialogueContainer GreetingDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_GreetingDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_GreetingDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x06003C48 RID: 15432 RVA: 0x00134864 File Offset: 0x00132A64
		// (set) Token: 0x06003C49 RID: 15433 RVA: 0x0001E8EE File Offset: 0x0001CAEE
		public unsafe string GreetedVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_GreetedVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_GreetedVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x06003C4A RID: 15434 RVA: 0x0013488C File Offset: 0x00132A8C
		// (set) Token: 0x06003C4B RID: 15435 RVA: 0x0001E90D File Offset: 0x0001CB0D
		public unsafe string IntroductionMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_IntroductionMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_IntroductionMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012C6 RID: 4806
		// (get) Token: 0x06003C4C RID: 15436 RVA: 0x001348B4 File Offset: 0x00132AB4
		// (set) Token: 0x06003C4D RID: 15437 RVA: 0x0001E92C File Offset: 0x0001CB2C
		public unsafe string IntroSentVariable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_IntroSentVariable);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_IntroSentVariable), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170012C7 RID: 4807
		// (get) Token: 0x06003C4E RID: 15438 RVA: 0x001348DC File Offset: 0x00132ADC
		// (set) Token: 0x06003C4F RID: 15439 RVA: 0x0001E94B File Offset: 0x0001CB4B
		public unsafe FullRank IntroRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_IntroRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_IntroRank)) = value;
			}
		}

		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x06003C50 RID: 15440 RVA: 0x00134904 File Offset: 0x00132B04
		// (set) Token: 0x06003C51 RID: 15441 RVA: 0x0001E966 File Offset: 0x0001CB66
		public unsafe int IntroDaysPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_IntroDaysPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_IntroDaysPlayed)) = value;
			}
		}

		// Token: 0x170012C9 RID: 4809
		// (get) Token: 0x06003C52 RID: 15442 RVA: 0x0013492C File Offset: 0x00132B2C
		// (set) Token: 0x06003C53 RID: 15443 RVA: 0x0001E981 File Offset: 0x0001CB81
		public unsafe float IntroNetworth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_IntroNetworth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_IntroNetworth)) = value;
			}
		}

		// Token: 0x170012CA RID: 4810
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x00134954 File Offset: 0x00132B54
		// (set) Token: 0x06003C55 RID: 15445 RVA: 0x0001E99C File Offset: 0x0001CB9C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012CB RID: 4811
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x0013497C File Offset: 0x00132B7C
		// (set) Token: 0x06003C57 RID: 15447 RVA: 0x0001E9B7 File Offset: 0x0001CBB7
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Ray.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040027BA RID: 10170
		private static readonly IntPtr NativeFieldInfoPtr_GreetingDialogue;

		// Token: 0x040027BB RID: 10171
		private static readonly IntPtr NativeFieldInfoPtr_GreetedVariable;

		// Token: 0x040027BC RID: 10172
		private static readonly IntPtr NativeFieldInfoPtr_IntroductionMessage;

		// Token: 0x040027BD RID: 10173
		private static readonly IntPtr NativeFieldInfoPtr_IntroSentVariable;

		// Token: 0x040027BE RID: 10174
		private static readonly IntPtr NativeFieldInfoPtr_IntroRank;

		// Token: 0x040027BF RID: 10175
		private static readonly IntPtr NativeFieldInfoPtr_IntroDaysPlayed;

		// Token: 0x040027C0 RID: 10176
		private static readonly IntPtr NativeFieldInfoPtr_IntroNetworth;

		// Token: 0x040027C1 RID: 10177
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040027C2 RID: 10178
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040027C3 RID: 10179
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040027C4 RID: 10180
		private static readonly IntPtr NativeMethodInfoPtr_Loaded_Private_Void_0;

		// Token: 0x040027C5 RID: 10181
		private static readonly IntPtr NativeMethodInfoPtr_EnableGreeting_Private_Void_0;

		// Token: 0x040027C6 RID: 10182
		private static readonly IntPtr NativeMethodInfoPtr_SetGreeted_Private_Void_0;

		// Token: 0x040027C7 RID: 10183
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040027C8 RID: 10184
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040027C9 RID: 10185
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040027CA RID: 10186
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040027CB RID: 10187
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
